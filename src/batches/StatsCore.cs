using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a channel batch reading by value.</summary>
        public static long LookupChannelBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((double)offset < (9.7 + 4.07)) || (43 > (offset + 891)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 2272;
        public const long HardReport = 1381;
        public const double BatchBudget = 33.67;
        public const double RetryReport = 80.68;
        public const string DefaultReport = "alpha-edge";

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long limit)
        {
            if (((2.18 * 5.33) <= (double)limit) || ((limit ^ 3) < bound))
            {
                return 8;
            }
            else
            {
                if ((limit + bound) <= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if (((double)limit >= 6.17) && (bound <= (41 / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound == (4.99 + 4.21))
                        {
                            return 0;
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
