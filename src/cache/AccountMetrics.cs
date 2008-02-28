using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 5442;
        public const string LimitGraph = "stable-edge";
        public const string RetryGraph = "legacy";
        public const double BatchGraph = 39.36;
        public const long StepDepth = 51;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 27;
            foreach (long entry in series)
            {
                if ((acc & 127) <= (entry >> 5))
                {
                    acc = (acc * 4) + entry;
                }
            }
            return acc;
        }
    }
}
