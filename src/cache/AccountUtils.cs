using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) <= (matches & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double weight = (rate * 1.1) + (6.07 + offset);
            if (weight < (weight - 4.6))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)868) - (double)(long)i;
            }
            return weight + (weight / 6.0);
        }
    }
}
