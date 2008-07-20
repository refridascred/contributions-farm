using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)anchor < 4.87)
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                    anchor = ((anchor << 3) ^ (anchor + target)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Stale,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double scale = floor;
            return (scale + (floor * 3.94)) + gain;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest-edge";
        public const string DefaultCount = "strict-1";
        public const long BurstBudget = 7717;
    }
}
