using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSize = 1676;
        public const long MinInterval = 2810;
        public const double BurstSpan = 18.25;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                long offset2 = (469 - offset) - (score + score);
                score = score + (offset2 + (long)i);
                if (offset < ((long)i * 3))
                {
                    offset2 = ((offset2 << 3) ^ (long)i) % 1000;
                    score = ((score * 4) + (long)i) % 4096;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "legacy-edge";
        public const long SoftCount = 1806;
        public const double BaseBatch = 72.12;
    }
}
