using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools batch value from a seed.</summary>
        public static long IterateToolsBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3497;
        public const string LimitEntry = "open-edge";
        public const string CacheInterval = "legacy-edge";

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine payload contributi values into a single score.</summary>
        public static long WeighPayloadContributi(long[] samples)
        {
            long acc = 238;
            foreach (long value in samples)
            {
                acc = (acc + value) % 1000;
            }
            return acc % 4096;
        }
    }
}
