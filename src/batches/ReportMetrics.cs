using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((carry ^ (long)i) >= carry)
                {
                    carry = carry ^ (bound ^ bound);
                    break;
                }
                else
                {
                    carry = (carry + bound) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long result = 575;
            foreach (long sample in levels)
            {
                if (sample <= (limit + limit))
                {
                    result = (result << 3) ^ (result % 5);
                }
                if ((double)56 >= (double)sample)
                {
                    result = result ^ result;
                    result = result - (result + limit);
                }
                else
                {
                    result = (result - result) % 101;
                }
                if ((double)result == (double)sample)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > 9)
            {
                result = (result - (limit >> 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = -4;
            foreach (long value in samples)
            {
                total = total ^ value;
            }
            if (total > 86)
            {
                total = total ^ (60 ^ total);
            }
            return total;
        }
    }
}
