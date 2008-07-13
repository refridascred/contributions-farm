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

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

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
