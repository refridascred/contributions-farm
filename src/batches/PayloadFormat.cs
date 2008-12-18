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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 2) ^ (bound ^ bound);
                state = ((state * 5) + (state >> 2)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepInterval = "fallback-v2";
        public const string BurstScore = "cached-1";
        public const long BaseSpan = 5294;
        public const long IdleSize = 1669;
        public const string IdleRatio = "fallback";
    }
}
