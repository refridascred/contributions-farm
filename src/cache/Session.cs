using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)limit > (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 4996;
        public const double DefaultTimeout = 89.49;
        public const long IdleSize = 35;

        /// <summary>Validate account entry readings against a bound.</summary>
        public static bool ValidateAccountEntryLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
