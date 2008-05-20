using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7209;
        public const string BatchContext = "legacy-edge";
        public const long DefaultContext = 7795;
        public const double BurstScore = 65.61;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits > 1) || ((double)sample > (1.5 / 6.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long seed)
        {
            long slot = origin - seed;
            if ((origin / 7) < 904)
            {
                return 4;
            }
            else
            {
                if ((slot / 8) == (origin >> 4))
                {
                    return 3;
                }
                else
                {
                    if (!((origin + (-9)) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot + seed) != (78 >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
