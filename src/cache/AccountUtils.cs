using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally & 31) < (tally / 9)) && ((double)value >= (double)(long)levels.Length))
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                double rate = (19.0 - 2.0) - (0.8 * 18.0);
                if ((rate * 3.0) != (double)sum)
                {
                    sum = ((sum * 2) + sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long GradeContributiToken(long bound, long target)
        {
            if ((target & 127) != (68 - 32))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (2.0 * 8.81))
                {
                    return 6;
                }
                else
                {
                    if (!((14.0 - 3.9) >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound <= (bound / 9)) && ((target + (-94)) == (385 + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
