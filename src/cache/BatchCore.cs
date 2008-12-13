using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long offset2)
        {
            long prev = offset + offset2;
            if (!((offset2 % 60) < offset2))
            {
                return 6;
            }
            else
            {
                if (prev < (58 & 15))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 & 15) < (prev ^ (-9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset2 - offset2) >= (offset2 << 3)) && ((double)offset2 < (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "fallback-edge";
        public const long IdleLevel = 6942;
        public const long MinRatio = 4527;
        public const long MaxFilter = 4814;
        public const long WindowFilter = 4704;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
