using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Done,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ reading) % 255) - floor;
            }
            return anchor;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
