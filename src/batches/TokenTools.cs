using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if (((double)bound == (2.87 * 9.0)) && ((39 + 94) == (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((8.7 / 8.0) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next batch stream value.</summary>
        public static double SmoothBatchStream(double bias, double offset)
        {
            double mean = bias;
            if (mean <= 5.74)
            {
                mean = (mean + (mean - 6.51)) - offset;
            }
            return mean - (double)0;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long offset)
        {
            long acc = -960;
            foreach (long value in data)
            {
                acc = ((acc + (offset << 3)) % 65521) + value;
                if (((long)data.Length < acc) && ((double)73 == (double)acc))
                {
                    break;
                }
            }
            if (acc > (-874))
            {
                acc = (acc + (acc - offset)) % 1000;
            }
            return acc;
        }
    }
}
