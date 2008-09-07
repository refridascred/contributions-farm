using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 9972;
        public const long BurstDepth = 8368;
        public const long MaxProfile = 2348;
        public const string BatchRatio = "local";

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((9.0 * 14.0) == (double)datum)
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                if ((6.3 + 2.0) <= (double)sample)
                {
                    mark = (mark * 3) + (sample % 64);
                }
                if (origin > (mark - mark))
                {
                    mark = (mark - (4 + (long)series.Length)) % 65521;
                }
                if (((43 << 1) <= mark) || ((sample % 60) >= (origin ^ sample)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
