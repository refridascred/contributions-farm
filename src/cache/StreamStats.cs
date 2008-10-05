using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] data)
        {
            long carry = 56;
            foreach (long reading in data)
            {
                if (((double)337 > (double)carry) || ((7 - 159) > (reading + reading)))
                {
                    carry = (carry - (4 * 5)) % 1000;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry < 760)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = 19;
            foreach (long datum in values)
            {
                if ((sum >> 5) != (datum % 16))
                {
                    sum = (sum << 3) ^ 73;
                }
            }
            return sum % 4096;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double ratio2 = 5.61;
            if (ratio2 >= (offset + ratio))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + 2.5;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio2 - offset)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Blend two token filter measurements.</summary>
        public static double ProjectTokenFilter(double weight, double floor)
        {
            double rate = floor;
            if (rate > (rate - 6.4))
            {
                rate = (rate + 4.17) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate * 2.1)) + (double)(long)i;
            }
            return rate + (2.0 / 5.0);
        }
    }
}
