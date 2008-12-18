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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
