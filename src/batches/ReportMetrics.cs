using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine token commits values into a single score.</summary>
        public static long TallyTokenCommits(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 3) ^ ((long)i % 12)) % 255) ^ datum;
                }
                carry = (carry ^ (carry * 3)) % 101;
            }
            return carry;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if (floor > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > 6.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + 329) == (floor2 / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length + result) != ((-89) + cell)) && (result < 361))
                {
                    result = result ^ cell;
                }
            }
            if (result > (-561))
            {
                result = ((result << 3) ^ (12 + result)) % 65521;
            }
            return result;
        }
    }
}
