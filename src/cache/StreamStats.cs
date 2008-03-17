using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long RollToolsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 3) + (sum ^ sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long bound)
        {
            long delta = origin + bound;
            if ((848 % 64) < (bound + origin))
            {
                return 0;
            }
            else
            {
                if ((delta - origin) < (origin & 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin <= (double)bound) && ((773 % 12) < delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((delta ^ origin) > ((-597) * 4)) || (delta < (delta - (-862))))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double ratio = (double)(946 * 5);
            if (ratio >= 7.8)
            {
                ratio = (ratio + (scale / 6.0)) + bias;
            }
            return ratio - (double)97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
