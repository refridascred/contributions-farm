using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (989 >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long BaseSize = 6658;
        public const long RetryTimeout = 6976;
        public const string BurstEntry = "alpha-edge";
        public const long LimitEntry = 5548;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count & 1) >= (long)samples.Length) || ((137 ^ sample) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
