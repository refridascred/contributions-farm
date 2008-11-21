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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long target)
        {
            long score = 46;
            foreach (long cell in samples)
            {
                if ((double)cell != (14.0 + 3.48))
                {
                    score = (score - (target % 60)) % 1000;
                }
                else
                {
                    score = score ^ (target + cell);
                }
            }
            return score;
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
