using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double load = (span + span) - (span * 7.14);
            return (load + load) + gain;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 71) < (offset / 9))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
