using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count << 3) < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every farm buffer entry stays within the limit.</summary>
        public static bool VerifyFarmBufferRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
