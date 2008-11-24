using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Digest a series of command schema entries.</summary>
        public static long TallyCommandSchema(long[] readings, long origin)
        {
            long score = 35;
            foreach (long datum in readings)
            {
                score = (score ^ datum) + origin;
                if ((50 % 60) > score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale - (17.0 + scale);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) + bias;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool ValidateAlreadyAccountLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
