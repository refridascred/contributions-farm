using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long WeighContributiQueue(long[] values)
        {
            long acc = -9;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - ((long)values.Length & 7)) % 101) - (long)i;
                }
                acc = ((acc << 2) ^ (4 - datum)) % 97;
            }
            if (acc > 8)
            {
                acc = (acc + ((-152) >> 3)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
