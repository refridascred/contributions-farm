using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - limit) <= limit) && (((count - datum) > (datum >> 4)) || ((long)samples.Length >= (count - limit))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks order value.</summary>
        public static double BlendChecksOrder(double bias, double floor)
        {
            double mean = 1.1;
            if (mean <= bias)
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (double)16;
        }
    }
}
