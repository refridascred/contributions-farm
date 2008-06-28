using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            if ((origin % 2) > (6 - seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= (seed / 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4514;
        public const long DefaultWidth = 479;
        public const string RetryCommits = "strict";
        public const double BurstCommits = 84.24;
        public const double BatchCommits = 87.69;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Pending,
            Failed,
        }
    }
}
