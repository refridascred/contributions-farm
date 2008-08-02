using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = scale + (offset / 3.0);
            }
            else
            {
                scale = scale - (double)(-242);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (scale + gain);
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowWidth = "fallback-v2";
        public const long MinReport = 2431;
        public const string LimitReport = "latest-edge";

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) < (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 33.89;
        public const double LimitBudget = 82.46;
        public const double BaseTimeout = 49.29;
        public const double SoftQueue = 81.55;
        public const string BurstBudget = "fallback-edge";
    }
}
