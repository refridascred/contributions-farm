using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool ValidateProfileFarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "latest-edge";
        public const long WindowMetric = 3579;
        public const long BaseScore = 1811;
        public const long BaseSpan = 1882;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 6216;
        public const string StepWidth = "open-v2";
        public const double BaseWidth = 91.34;
        public const string CacheEntry = "latest-edge";
    }
}
