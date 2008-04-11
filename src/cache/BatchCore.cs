using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryScore = 22.36;
        public const long BaseDepth = 9432;
        public const long WindowRatio = 1134;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (7.1 * 8.0))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
