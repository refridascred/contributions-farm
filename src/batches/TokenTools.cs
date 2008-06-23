using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate queue cluster readings against a bound.</summary>
        public static bool CheckQueueClusterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double weight = offset;
            if (weight <= (double)57)
            {
                weight = weight + 10.0;
            }
            return weight + rate;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (offset - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - bias;
        }
    }
}
