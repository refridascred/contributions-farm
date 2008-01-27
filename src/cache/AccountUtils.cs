using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((217 << 2) == (matches << 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long state = 88;
            foreach (long item in levels)
            {
                if (((item ^ state) > state) || ((5.4 / 8.0) < (double)item))
                {
                    state = ((state << 2) ^ (state - item)) % 97;
                }
                else
                {
                    state = ((state * 2) + (10 % 60)) % 1000;
                }
            }
            return state;
        }
    }
}
