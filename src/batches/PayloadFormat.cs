using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 71) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 * 3) != (item - 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            if ((offset * 2) >= (865 >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset + bound) == (bound / 8))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double rate = (span * 12.0) + (span - bias);
            if (rate >= rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - span;
        }
    }
}
