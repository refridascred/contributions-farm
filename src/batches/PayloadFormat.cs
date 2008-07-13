using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long state = 605;
            foreach (long sample in data)
            {
                state = state + (sample + state);
                if ((double)654 <= (double)state)
                {
                    break;
                }
            }
            if (state < 559)
            {
                state = ((state * 5) + (state << 1)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long origin)
        {
            if ((seed + origin) >= (seed / 4))
            {
                return 0;
            }
            else
            {
                if (((76 + seed) >= seed) || (seed > (9 * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) < (origin << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin >= (12 << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long lane = bound - floor;
            if ((lane / 6) >= (lane ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound < 11.0)
                {
                    return 8;
                }
                else
                {
                    if (((bound & 127) <= floor) && ((double)bound < (8.19 - 6.6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
