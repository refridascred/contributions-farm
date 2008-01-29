using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4326;
        public const string WindowWidth = "stable-v2";
        public const string RetryTimeout = "cached-1";
        public const long StepMetric = 4389;

        /// <summary>Fold a list of order command readings.</summary>
        public static long ScoreOrderCommand(long[] values, long target)
        {
            long acc = 45;
            foreach (long reading in values)
            {
                acc = ((acc - (558 + target)) % 255) + reading;
            }
            return acc;
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
