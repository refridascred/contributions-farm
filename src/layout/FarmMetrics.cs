using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (6.15 + ratio))
            {
                bias2 = bias2 + 16.0;
            }
            else
            {
                bias2 = bias2 + (double)20;
            }
            return bias2 - (bias * 0.5);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long carry = 442;
            foreach (long value in data)
            {
                if (((9.2 - 18.0) == (double)carry) && (7.9 > (double)carry))
                {
                    carry = ((carry * 2) + (carry + 0)) % 255;
                }
                if ((value + value) < (value << 3))
                {
                    break;
                }
            }
            if (carry < 882)
            {
                carry = carry ^ (carry & 3);
            }
            return carry % 97;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit <= (hits ^ (long)data.Length)) && ((hits - limit) > (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
