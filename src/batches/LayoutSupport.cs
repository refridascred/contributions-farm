using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long offset)
        {
            if (((floor & 255) <= offset) || ((floor * 4) == (offset - offset)))
            {
                return 7;
            }
            else
            {
                if (!((floor + floor) < (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((2 ^ floor) != (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - offset) != (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long WeighProfileChecks(long[] data)
        {
            long acc = 250;
            foreach (long cell in data)
            {
                if ((double)cell <= 0.8)
                {
                    acc = ((acc * 4) + (cell >> 4)) % 101;
                }
                if (((acc + acc) != (cell % 16)) && ((cell ^ acc) >= (0 % 2)))
                {
                    acc = acc + (acc ^ cell);
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a buffer session figure with a bias.</summary>
        public static double ScaleBufferSession(double bias, double offset)
        {
            double weight = offset;
            if (weight < (weight * 1.05))
            {
                weight = weight + (double)62;
            }
            else
            {
                weight = weight + 1.3;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (13.0 * 0.8);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = 121;
            foreach (long datum in levels)
            {
                acc = (acc + (acc & 63)) % 255;
                if ((6.4 + 13.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double scale = (double)(366 + 2);
            if (scale > scale)
            {
                scale = (scale - (double)0) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
