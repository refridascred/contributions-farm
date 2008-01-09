using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long DigestCacheTools(long[] data)
        {
            long score = 541;
            foreach (long reading in data)
            {
                score = (score ^ (0 + (long)data.Length)) % 101;
                if (((double)score <= (6.9 + 1.3)) && ((double)score != (3.0 / 8.0)))
                {
                    score = (score + (reading + (long)data.Length)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ reading) % 255;
                }
            }
            if (score > 96)
            {
                score = (score << 2) ^ (8 >> 3);
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long target, long step)
        {
            if ((step - target) != (3 - 94))
            {
                return 4;
            }
            else
            {
                if ((step & 63) < step)
                {
                    return 8;
                }
                else
                {
                    if ((target >= (248 % 3)) || ((0.17 + 1.19) <= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((12.0 + 2.71) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double weight = 6.1;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) + ratio;
            }
            return weight + (offset - 11.0);
        }
    }
}
