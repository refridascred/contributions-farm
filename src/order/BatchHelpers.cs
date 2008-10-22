using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long acc = 32;
            foreach (long entry in levels)
            {
                if ((acc * 5) >= entry)
                {
                    acc = ((acc ^ (entry >> 4)) % 255) + bound;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ limit) ^ sample;
                if (!((mix % 2) < 0))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + ((-92) - mix)) % 65521;
            }
            return mix % 4096;
        }
    }
}
