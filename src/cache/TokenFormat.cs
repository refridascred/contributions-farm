using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long seed)
        {
            if (seed > (5 * 4))
            {
                return 3;
            }
            else
            {
                if ((seed % 5) != (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed + step) > 9)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 / 5.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = carry ^ (item / 3);
                if (((carry / 2) >= (78 >> 1)) && ((item + item) > (carry + carry)))
                {
                    carry = ((carry * 4) + (item + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
