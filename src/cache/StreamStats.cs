using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context metrics samples.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long total = 10;
            foreach (long entry in levels)
            {
                if (entry > (78 + total))
                {
                    total = total ^ ((long)levels.Length / 5);
                }
            }
            if (total < 8)
            {
                total = (total + (total << 3)) % 255;
            }
            return total;
        }
    }
}
