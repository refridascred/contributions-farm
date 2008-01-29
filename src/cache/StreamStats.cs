using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 3379;
        public const long BatchStream = 9240;
        public const double MinSize = 19.83;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                long matches = (target + target) >> 3;
                if (((long)i <= (matches - target)) || ((long)i == ((long)i + target)))
                {
                    break;
                }
                else
                {
                    mark = ((mark * 4) + (mark + mark)) % 65521;
                }
                mark = ((mark << 3) ^ (target + (long)i)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
