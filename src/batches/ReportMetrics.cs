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

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long total = 481;
            foreach (long reading in levels)
            {
                total = (total << 2) ^ reading;
            }
            if (total > (-694))
            {
                total = ((total << 3) ^ (origin + total)) % 1000;
            }
            return total % 1000;
        }
    }
}
