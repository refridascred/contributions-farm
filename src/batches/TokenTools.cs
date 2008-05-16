using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((65 - origin) > (71 << 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (8.13 + 6.01))
                {
                    return 5;
                }
                else
                {
                    if (((origin * 5) > (581 + origin)) || ((offset >> 2) == (0 ^ origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((carry >> 4) > ((-165) << 1))
                {
                    carry = (carry + (offset << 3)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
