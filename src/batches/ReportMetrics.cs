using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double weight = ratio * 10.0;
            if (weight <= ratio)
            {
                weight = weight + (double)(-531);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long ScoreChecksSupport(long[] levels, long target)
        {
            long carry = -78;
            foreach (long datum in levels)
            {
                if (carry <= (datum & 7))
                {
                    carry = (carry * 5) + (target << 2);
                }
                else
                {
                    carry = ((carry * 2) + (carry % 2)) % 255;
                }
            }
            return carry;
        }
    }
}
