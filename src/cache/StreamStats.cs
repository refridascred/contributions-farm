using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 6854;
        public const long CacheFormat = 9527;
        public const double BurstFormat = 43.59;
        public const string StepFormat = "open-edge";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long total = 5;
            foreach (long item in values)
            {
                if ((item & 1) >= total)
                {
                    total = (((total << 2) ^ (total + total)) % 101) + offset;
                    break;
                }
                total = (total + (item >> 2)) % 97;
                total = ((total << 3) ^ (item + item)) % 1000;
            }
            if (total < (-30))
            {
                total = ((total << 2) ^ (1 + total)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
