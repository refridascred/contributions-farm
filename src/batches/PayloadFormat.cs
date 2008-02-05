using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitInterval = 4036;
        public const double BaseLayout = 4.88;
        public const string BurstSpan = "legacy-1";

        /// <summary>Compare every pair of githubfarm counter readings.</summary>
        public static long CompareGithubfarmCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "legacy-1";
        public const double CacheWindow = 20.1;
        public const double BaseWidth = 1.71;
        public const long IdleBudget = 7804;
    }
}
