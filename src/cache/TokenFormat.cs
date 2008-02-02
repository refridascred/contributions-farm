using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7110;
        public const long CacheFactor = 377;
        public const string RetryScore = "local-1";
        public const long CacheContributi = 6976;
        public const long SoftContributi = 8667;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((9.4 / 2.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((144 + bound) != (27 << 2))
                {
                    return 1;
                }
                else
                {
                    if ((gap + 2) >= (origin ^ 965))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin > (gap + bound)) && ((838 >> 5) <= (gap + gap)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Draft,
            Paused,
            Closed,
            Stale,
        }
    }
}
