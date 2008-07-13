using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 7477;
        public const long RetryDepth = 6967;
        public const long BatchTools = 7710;
        public const string MaxInterval = "standard";
        public const long WindowTools = 9864;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((total % 5) < (total + total)) || (total <= (origin & 15)))
                {
                    total = total - 21;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
