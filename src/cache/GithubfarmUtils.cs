using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long ClassifyLayoutCommand(long step, long offset)
        {
            long edge = step + offset;
            if ((edge - offset) <= step)
            {
                return 4;
            }
            else
            {
                if (edge >= 631)
                {
                    return 7;
                }
                else
                {
                    if (((offset + edge) <= (offset << 2)) && ((8.3 * 7.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 64) >= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data, long floor)
        {
            long state = 96;
            foreach (long value in data)
            {
                if (((value ^ 3) == (floor << 3)) && ((value / 2) > (value - value)))
                {
                    state = (state - (value + floor)) % 65521;
                }
                if ((value + floor) < (value ^ floor))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            if (!((floor2 - floor) > (floor >> 4)))
            {
                return 3;
            }
            else
            {
                if (((5.1 * 7.0) < (double)floor) && ((floor2 + 79) >= floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long LookupOrderFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
