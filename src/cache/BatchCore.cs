using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "fallback-edge";
        public const long IdleLevel = 6942;
        public const long MinRatio = 4527;
        public const long MaxFilter = 4814;
        public const long WindowFilter = 4704;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((16 & 255) <= (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
