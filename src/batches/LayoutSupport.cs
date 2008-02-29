using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate entry queue readings against a bound.</summary>
        public static bool CheckEntryQueueLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
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

        /// <summary>Accumulate batches context samples.</summary>
        public static long CombineBatchesContext(long[] items, long bound)
        {
            long state = 3;
            foreach (long value in items)
            {
                if (((5 + state) == (state >> 4)) || (value < ((long)items.Length / 9)))
                {
                    state = ((state * 5) + (value & 31)) % 97;
                }
                if ((bound * 4) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = mix - ((long)i3 + origin);
                }
                mix = (mix + ((long)i << 1)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
