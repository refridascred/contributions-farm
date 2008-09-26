using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of record schema entries.</summary>
        public static long WeighRecordSchema(long[] levels, long limit)
        {
            long carry = 48;
            foreach (long sample in levels)
            {
                carry = ((carry + (sample % 3)) % 4096) - limit;
                if (carry <= ((-17) / 4))
                {
                    carry = (carry + (sample % 60)) % 101;
                }
                else
                {
                    carry = (carry + (sample - carry)) % 101;
                }
            }
            if (carry > 32)
            {
                carry = (carry * 2) + (carry - carry);
            }
            return carry % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((17.0 * 5.99) != (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
