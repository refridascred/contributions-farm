using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Digest a series of cache route entries.</summary>
        public static long TallyCacheRoute(long[] series, long step)
        {
            long mix = 32;
            foreach (long sample in series)
            {
                if ((sample > (step & 15)) && ((3.56 - 8.4) > (double)step))
                {
                    mix = (mix << 3) ^ (long)series.Length;
                }
                if ((5 * 4) < (sample >> 5))
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix * 2) + step;
            }
            return mix % 4096;
        }
    }
}
