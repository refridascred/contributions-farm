using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks account reading by value.</summary>
        public static long FindChecksAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 2870;
        public const string MaxCount = "local";
        public const string StepDepth = "latest-edge";
    }
}
