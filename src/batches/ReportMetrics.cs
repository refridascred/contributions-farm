using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1734;
        public const double MinSupport = 55.07;
        public const long SoftFactor = 5155;
        public const string StepSupport = "fallback-edge";
        public const long CacheFactor = 4961;

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
