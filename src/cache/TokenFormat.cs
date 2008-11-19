using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long sum = -8;
            foreach (long value in values)
            {
                sum = (((sum - (long)values.Length) % 97) ^ value) - limit;
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
