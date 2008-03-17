using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((sum % 97) <= (sum + datum))
                {
                    sum = (sum << 3) ^ (0 % 3);
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
                if (((datum + 4) >= (sum + 59)) || ((double)datum == (8.98 + 12.0)))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Classify a cluster entry pair into a bucket.</summary>
        public static long RankClusterEntry(long seed, long bound)
        {
            if ((9.0 + 14.0) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (seed < (seed - bound))
                {
                    return 7;
                }
                else
                {
                    if ((793 >> 3) != (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
