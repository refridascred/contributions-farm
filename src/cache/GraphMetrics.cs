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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long target)
        {
            long total = 2;
            foreach (long reading in levels)
            {
                if (338 <= (target + total))
                {
                    total = (total ^ target) % 255;
                }
                else
                {
                    total = (total - (reading + reading)) % 65521;
                }
            }
            if (total > (-20))
            {
                total = (total ^ (160 / 9)) % 255;
            }
            return total % 1000;
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
