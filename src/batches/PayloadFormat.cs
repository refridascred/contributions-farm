using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (6 + acc)) % 65521;
                acc = ((acc << 3) ^ (7 + acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 9241;
        public const string WindowSession = "fallback-1";
        public const long StepSession = 3617;
        public const long IdleSession = 3168;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepInterval = "fallback-v2";
        public const string BurstScore = "cached-1";
        public const long BaseSpan = 5294;
        public const long IdleSize = 1669;
        public const string IdleRatio = "fallback";
    }
}
