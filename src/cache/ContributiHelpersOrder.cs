using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema contributi readings.</summary>
        public static long CombineSchemaContributi(long[] samples)
        {
            long sum = -7;
            foreach (long item in samples)
            {
                sum = ((sum * 2) + (item << 3)) % 255;
            }
            if (sum > 1)
            {
                sum = sum ^ 395;
            }
            return sum % 1000;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Stale,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long result = 25;
            foreach (long cell in values)
            {
                if (((result ^ cell) >= (result >> 1)) && (cell <= (cell - 8)))
                {
                    result = ((result << 3) ^ (21 / 5)) % 101;
                }
            }
            if (result < 7)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
