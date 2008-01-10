using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of commits context readings.</summary>
        public static long WeighCommitsContext(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((value + 8) != (value * 4))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item * 4) <= ((-300) & 255))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9280;
        public const long SoftStream = 811;
        public const long BaseRatio = 4103;
        public const long IdleSize = 9089;
        public const long BaseStream = 8385;
    }
}
