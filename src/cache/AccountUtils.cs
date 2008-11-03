using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count == (12.0 + 0.3))
                {
                    count = ((count + 3) + cell) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long floor)
        {
            if ((target + floor) <= (target << 3))
            {
                return 1;
            }
            else
            {
                if (!((floor & 63) == (1 + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((double)60 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target != (10.0 / 3.0)) || ((target << 2) != (floor & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + (-5)) >= (origin % 60))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
