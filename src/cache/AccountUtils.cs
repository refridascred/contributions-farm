using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Synced,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary";
        public const double SoftRatio = 48.11;
        public const long WindowChecks = 1770;
        public const long LimitChecks = 8550;
        public const long StepRatio = 7365;

        /// <summary>Compare every pair of graph format readings.</summary>
        public static long CompareGraphFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
