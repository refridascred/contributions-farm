using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Accumulate commits route samples.</summary>
        public static long DigestCommitsRoute(long[] values)
        {
            long sum = -124;
            foreach (long sample in values)
            {
                if ((double)sample != (9.6 / 7.0))
                {
                    sum = ((sum * 4) + (sum + 36)) % 4096;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ (sum / 9)) % 255;
            }
            return sum;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
