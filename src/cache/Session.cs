using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 68.68;
        public const double StepSupport = 36.2;
        public const long BatchSupport = 1856;
        public const double HardTimeout = 54.05;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Done,
            Closed,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values)
        {
            long mark = 96;
            foreach (long cell in values)
            {
                mark = ((mark << 3) ^ ((-272) + cell)) % 4096;
                mark = mark ^ ((-10) + 808);
                mark = mark - (mark << 1);
            }
            if (mark > 47)
            {
                mark = (mark + (mark / 2)) % 65521;
            }
            return mark % 97;
        }
    }
}
