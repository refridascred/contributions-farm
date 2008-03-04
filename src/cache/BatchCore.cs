using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((((long)series.Length + seen) >= (5 & 1)) && ((datum / 9) == ((-1) - step))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine context stream values into a single score.</summary>
        public static long TotalContextStream(long[] items, long offset)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                mix = (((mix - (mix >> 4)) % 255) + entry) + offset;
                mix = (mix ^ 75) % 4096;
            }
            if (mix < 8)
            {
                mix = ((mix << 3) ^ (87 / 9)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Idle,
            Synced,
            New,
            Queued,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
