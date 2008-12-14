using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 12.63;
        public const string BatchBudget = "open-edge";
        public const long IdleCount = 4207;
        public const string BatchSupport = "local-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)span > (8.3 * 9.11))
            {
                return 6;
            }
            else
            {
                if (target >= (span + floor))
                {
                    return 1;
                }
                else
                {
                    if (499 >= (floor ^ 480))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 & 3) > (floor & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items, long offset)
        {
            long acc = 56;
            foreach (long entry in items)
            {
                if (acc > (entry - offset))
                {
                    acc = (acc * 2) + (acc * 3);
                }
                if ((double)offset == (double)242)
                {
                    acc = (acc + entry) % 1000;
                    acc = ((acc << 2) ^ (entry * 5)) % 4096;
                }
                if ((entry - offset) <= (entry + acc))
                {
                    acc = acc ^ (entry * 4);
                }
                else
                {
                    acc = ((acc << 3) ^ (entry ^ offset)) % 255;
                }
                if ((double)entry != (1.5 * 0.92))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
