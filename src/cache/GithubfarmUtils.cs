using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > (1.0 + 9.93))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long carry = -27;
            foreach (long value in samples)
            {
                if (((value + value) > (carry + value)) || ((16.0 + 3.52) >= (double)value))
                {
                    carry = ((carry * 4) + (carry - carry)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchWidth = 68.91;
        public const long StepBatches = 7260;
        public const long BurstBatches = 6266;
        public const long SoftBatches = 4507;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 3683;
        public const long RetryWidth = 1565;
        public const long MinNotes = 8093;
        public const long RetryTimeout = 777;
        public const long StepSpan = 3369;
    }
}
