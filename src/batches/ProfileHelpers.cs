using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 6348;
        public const long BatchBuffer = 7438;
        public const long WindowTimeout = 3889;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)step > (double)15)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch order value from a seed.</summary>
        public static long IterateBatchOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i > (3.6 - 4.01))
                {
                    carry = ((carry * 3) + target) % 101;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long DigestFilterSession(long[] data, long bound)
        {
            long state = -968;
            foreach (long datum in data)
            {
                if ((datum & 63) < datum)
                {
                    state = ((state ^ (datum + datum)) % 1000) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
