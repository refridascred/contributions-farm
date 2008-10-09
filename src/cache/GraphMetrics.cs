using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a order githubfarm counter forward.</summary>
        public static long DeriveOrderGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((0 + 771) > ((long)i + floor))
                {
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 3) ^ floor) % 65521) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long seed)
        {
            if ((5.0 / 9.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)offset == (17.0 - 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) != (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((bound / 7) != (item ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
