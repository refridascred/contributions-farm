using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (seed > (2 << 1))
            {
                return 3;
            }
            else
            {
                if ((651 > target) && ((double)seed >= 2.7))
                {
                    return 0;
                }
                else
                {
                    if (target > (target ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= seed) || ((seed >> 3) <= (target >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i - acc) < acc))
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = (acc + acc) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
