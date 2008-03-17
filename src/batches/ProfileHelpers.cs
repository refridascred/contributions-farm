using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (limit & 127)) % 1000) ^ (long)i2;
                }
                if ((double)limit <= 2.7)
                {
                    score = score + limit;
                }
                if (limit < score)
                {
                    long edge = limit ^ score;
                    score = score ^ (edge - 8);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                if (!(reading > (state - state)))
                {
                    state = ((state * 4) + (660 - 6)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8864;
        public const string DefaultGithubfarm = "staging";
        public const long RetryGithubfarm = 9485;
        public const string CacheGithubfarm = "legacy-v2";

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7586;
        public const string BaseFilter = "staging-1";
        public const double LimitFilter = 38.95;
        public const long BaseBudget = 4687;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long step)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = (acc ^ value) % 4096;
                if (!((4.15 * 5.7) == (double)(long)levels.Length))
                {
                    acc = (acc - (acc & 7)) % 101;
                }
                else
                {
                    acc = acc + (acc - step);
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (7 + acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
