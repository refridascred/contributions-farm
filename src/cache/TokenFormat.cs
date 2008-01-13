using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if ((floor / 4) < (floor % 97))
            {
                return 8;
            }
            else
            {
                if (!((floor * 3) >= (55 & 255)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of entry notes readings.</summary>
        public static long CombineEntryNotes(long[] levels, long step)
        {
            long sum = 217;
            foreach (long datum in levels)
            {
                sum = ((((sum * 5) + (-30)) % 97) ^ datum) + step;
            }
            if (sum > 7)
            {
                sum = (sum * 5) + (sum >> 5);
            }
            return sum % 65521;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
