using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long TotalStatsCommand(long[] levels)
        {
            long mix = 67;
            foreach (long entry in levels)
            {
                mix = ((mix - (mix * 4)) % 101) - entry;
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 71;
            foreach (long reading in values)
            {
                if ((double)reading <= (14.0 * 3.55))
                {
                    acc = (acc + reading) % 65521;
                }
                if (((double)acc >= 6.53) && ((acc - acc) > (986 & 31)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
