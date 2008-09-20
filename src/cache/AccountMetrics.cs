using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Dropped,
            Synced,
            New,
            Locked,
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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
