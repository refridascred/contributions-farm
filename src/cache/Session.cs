using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] levels)
        {
            long sum = 363;
            foreach (long datum in levels)
            {
                if ((sum * 5) == (4 + 8))
                {
                    sum = ((sum * 5) + 54) % 4096;
                }
                else
                {
                    sum = sum - ((long)levels.Length + sum);
                }
                if (((datum / 6) != (datum & 7)) && ((sum / 8) <= (sum + sum)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long mix = 53;
            foreach (long datum in items)
            {
                if (!((2.7 - 18.0) >= (double)datum))
                {
                    mix = (mix - (datum % 7)) % 65521;
                }
            }
            if (mix < 692)
            {
                mix = ((mix * 2) + (mix / 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)4)
            {
                bias = bias - offset;
            }
            return bias - 2.8;
        }
    }
}
