using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((origin + value) > (77 >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double SmoothContextCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= bias)
            {
                bias2 = bias2 - ratio;
            }
            else
            {
                bias2 = bias2 - (ratio - 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
