using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 967;
        public const long MinBudget = 2292;
        public const long BaseFactor = 4253;
        public const double RetryFactor = 83.14;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long acc = 8;
            foreach (long datum in samples)
            {
                if (((datum - acc) < datum) && ((8.0 - 6.5) >= (6.01 / 5.0)))
                {
                    acc = (acc ^ (56 + 216)) % 65521;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
