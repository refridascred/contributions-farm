using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long carry = 971;
            foreach (long sample in readings)
            {
                carry = (carry ^ (carry + carry)) - sample;
            }
            return carry;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long seed)
        {
            long bound = limit + seed;
            if (limit < (bound - bound))
            {
                return 4;
            }
            else
            {
                if (((bound - seed) >= seed) || ((limit & 255) != (0 % 8)))
                {
                    return 2;
                }
                else
                {
                    if (((6.0 + 2.0) < (double)bound) && ((double)bound < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - tally) >= (tally & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
