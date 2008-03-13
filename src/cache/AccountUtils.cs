using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double mean = (5.64 * 8.6) + span;
            if (mean < span)
            {
                mean = (mean - span) - rate;
            }
            else
            {
                mean = mean - span;
            }
            return mean - 14.0;
        }
    }
}
