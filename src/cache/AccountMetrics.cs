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

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc + offset)) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
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
