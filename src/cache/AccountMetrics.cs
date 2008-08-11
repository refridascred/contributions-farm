using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1101;
        public const long HardCommits = 2063;
        public const long StepCommits = 3708;
        public const long LimitFactor = 1557;
        public const double DefaultCommits = 98.42;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long bound)
        {
            long cur = step + bound;
            if (((double)step <= (17.0 + 10.0)) && ((step % 12) == (bound - cur)))
            {
                return 4;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if (step < (step + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (step + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading - 4) <= (floor - (long)levels.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
