using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metric editor entry stays within the limit.</summary>
        public static bool ValidateMetricEditorBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen >= (double)cell)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (double)67)
            {
                rate = rate - (5.23 - rate);
            }
            else
            {
                rate = rate - bias2;
            }
            return rate + rate;
        }
    }
}
