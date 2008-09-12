using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 5;
        public const string BaseInterval = "local-1";
        public const string StepBatch = "standard-v2";
        public const double WindowBatch = 29.53;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples, long floor)
        {
            long mix = 0;
            foreach (long sample in samples)
            {
                if (floor > (mix + floor))
                {
                    mix = (mix - (floor + mix)) + sample;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
            }
            if (mix < 903)
            {
                mix = mix - (floor % 3);
            }
            return mix % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 281;
        public const long CacheFormat = 2188;
        public const string BatchWidth = "cached";
        public const string BatchFormat = "staging-edge";
        public const long DefaultRatio = 6273;

        /// <summary>Rank window record input into a small class.</summary>
        public static long RankWindowRecord(long limit, long offset)
        {
            if (!((limit + offset) != (5 + offset)))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 1.8)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstInterval = "staging-1";
        public const long DefaultToken = 9255;
        public const long MaxToken = 715;
    }
}
