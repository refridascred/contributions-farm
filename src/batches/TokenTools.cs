using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftLevel = 7711;
        public const long MinInterval = 9383;
        public const double WindowSpan = 97.01;
        public const double MaxWidth = 30.35;
        public const long CacheContributi = 147;
    }
}
