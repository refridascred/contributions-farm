using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of farm editor readings.</summary>
        public static long CompareFarmEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long floor)
        {
            if (((step ^ floor) < (floor % 8)) && ((step % 16) != (step - floor)))
            {
                return 1;
            }
            else
            {
                if ((45 + floor) != ((-2) - step))
                {
                    return 3;
                }
                else
                {
                    if ((3.5 * 17.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long origin)
        {
            if ((origin > floor) || (floor < (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) > (origin + (-24))) && ((floor - 2) >= 643))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
