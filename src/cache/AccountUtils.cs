using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the commits route entries that pass the check.</summary>
        public static long CountCommitsRouteGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)seed >= (double)8)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
