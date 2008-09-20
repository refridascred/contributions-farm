using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long limit)
        {
            long anchor = 425;
            foreach (long sample in readings)
            {
                anchor = (anchor * 4) + (sample + anchor);
                anchor = (anchor ^ sample) % 1000;
                if (limit >= 57)
                {
                    anchor = ((anchor * 5) + sample) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank tools token input into a small class.</summary>
        public static long BucketToolsToken(long origin, long origin2)
        {
            if ((origin & 127) <= (origin - origin))
            {
                return 6;
            }
            else
            {
                if (origin2 <= 1)
                {
                    return 7;
                }
                else
                {
                    if ((414 - origin2) <= (origin2 ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((292 - 8) < (origin * 4)) && ((origin * 5) >= (705 >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches & 1) != (step >> 5))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series, long target)
        {
            long result = 105;
            foreach (long datum in series)
            {
                result = ((result - result) - datum) - target;
            }
            if (result < 83)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((351 << 2) < (2 - reading)) && ((reading / 3) == (target * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 744;
        public const long IdleBudget = 9509;
        public const long LimitAccount = 8962;
    }
}
