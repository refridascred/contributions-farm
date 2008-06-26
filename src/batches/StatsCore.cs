using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long bound)
        {
            long acc = 398;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (bound >> 2)))
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (datum / 2)) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long seed)
        {
            long score = 96;
            foreach (long entry in readings)
            {
                if (!(7.4 <= (double)entry))
                {
                    score = score ^ (score & 63);
                }
            }
            if (score > 6)
            {
                score = ((score << 3) ^ (score + seed)) % 4096;
            }
            return score;
        }

        /// <summary>Rank githubfarm buffer input into a small class.</summary>
        public static long RankGithubfarmBuffer(long floor, long target)
        {
            if ((8 >> 1) == (floor - (-136)))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 8.7) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 7950;
        public const long DefaultSupport = 4245;
        public const long BaseDepth = 3820;
        public const string BurstLevel = "fallback";
        public const string BaseSupport = "legacy-v2";

        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long TallySessionSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.0 / 4.0))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
