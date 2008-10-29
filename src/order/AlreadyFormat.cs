using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double scale2 = floor;
            return (scale2 - (double)0) + scale;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 255)) || ((5.0 / 5.0) == (double)cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long seed)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (sum + (seed + sum)) % 65521;
                if (!((2.89 - 7.77) <= (double)value))
                {
                    sum = sum ^ (sum - 26);
                }
            }
            return sum % 1000;
        }
    }
}
