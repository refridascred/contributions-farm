using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 2;
            foreach (long cell in levels)
            {
                if ((6.4 + 7.01) == (double)acc)
                {
                    acc = (acc - (cell * 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
