using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                mix = ((mix * 3) + 748) + entry;
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + (mix & 63)) % 101;
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((10 ^ cell) < ((long)series.Length - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 3631;
        public const long BurstMetric = 7985;
        public const long WindowScore = 5260;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
