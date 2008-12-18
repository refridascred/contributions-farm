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

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor - mark) >= (mark + (long)i))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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
