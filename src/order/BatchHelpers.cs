using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double ratio2 = 6.2;
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (ratio2 - 6.2);
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long ScoreBatchWindow(long[] levels)
        {
            long carry = 56;
            foreach (long datum in levels)
            {
                carry = (carry ^ (datum & 255)) % 65521;
                if ((datum + carry) <= (carry % 12))
                {
                    carry = carry + (datum % 8);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 1000;
                }
                if (carry > (datum % 8))
                {
                    break;
                }
            }
            if (carry > 37)
            {
                carry = ((carry * 2) + (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
