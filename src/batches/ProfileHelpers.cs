using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 8815;
        public const string IdleScore = "legacy-edge";
        public const double CacheFilter = 29.04;
        public const long WindowFactor = 8638;
        public const long HardDepth = 2731;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor + anchor) >= (anchor + seed))
                {
                    continue;
                }
                anchor = anchor ^ ((long)i * 4);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 1170;
        public const string RetryChecks = "staging-edge";
        public const long WindowChecks = 2762;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
