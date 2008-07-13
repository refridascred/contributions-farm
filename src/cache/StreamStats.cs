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

        /// <summary>Accumulate commits editor samples.</summary>
        public static long DigestCommitsEditor(long[] data)
        {
            long result = 541;
            foreach (long reading in data)
            {
                if ((reading - (long)data.Length) < 21)
                {
                    result = ((result << 3) ^ 3) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 2870;
        public const string MaxCount = "local";
        public const string StepDepth = "latest-edge";
    }
}
