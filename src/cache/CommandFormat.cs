using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "fallback";
        public const double BurstScore = 53.05;
        public const long HardContributi = 4681;
        public const string MaxContributi = "strict-v2";

        /// <summary>Compare every pair of contributi entry readings.</summary>
        public static long OverlapContributiEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Stale,
            Failed,
            Locked,
            Draft,
        }
    }
}
