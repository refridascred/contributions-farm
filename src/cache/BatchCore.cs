using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Locked,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long floor)
        {
            long acc = 1;
            foreach (long value in series)
            {
                acc = acc + (value & 7);
                acc = acc - (acc + floor);
            }
            if (acc < (-75))
            {
                acc = (acc ^ (floor + floor)) % 97;
            }
            return acc;
        }
    }
}
