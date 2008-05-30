using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ 6) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long bound)
        {
            if (!((884 ^ bound) <= (floor - bound)))
            {
                return 4;
            }
            else
            {
                if (((floor + floor) != (floor << 2)) || ((bound & 7) < floor))
                {
                    return 2;
                }
                else
                {
                    if (bound < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + bound) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score - offset) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
