using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate format stream readings against a bound.</summary>
        public static bool VerifyFormatStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long score = 49;
            foreach (long cell in data)
            {
                score = (score ^ (cell & 1)) % 1000;
                if (213 > score)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double rate = (double)(3 + 0);
            if (rate > (gain - 18.0))
            {
                rate = (rate - (gain / 9.0)) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
