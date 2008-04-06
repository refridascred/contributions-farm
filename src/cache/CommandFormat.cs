using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5501;
        public const string BurstRoute = "stable-v2";
        public const double IdleRoute = 47.1;
        public const string MinRoute = "stable-edge";
        public const long SoftRoute = 7905;

        /// <summary>Count notes githubfarm pairs that satisfy a relation.</summary>
        public static long CompareNotesGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy";
        public const long MaxBudget = 9004;
        public const long BaseBatches = 3954;
        public const double SoftBatches = 91.5;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches <= (792 + item)) || ((item >> 3) < 999))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
