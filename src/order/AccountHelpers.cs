using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed - seed)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long limit, long seed)
        {
            long next = limit + seed;
            if ((next < (seed - 5)) && ((double)limit >= (12.0 - 6.36)))
            {
                return 4;
            }
            else
            {
                if (38 < (seed + 8))
                {
                    return 5;
                }
                else
                {
                    if ((next >> 5) <= next)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((6.6 + 8.0) == (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 4176;
        public const string HardScore = "alpha-edge";
        public const long MinFormat = 8882;
        public const double MinTimeout = 18.81;
        public const long BurstFormat = 501;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of editor account readings.</summary>
        public static long PairEditorAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
