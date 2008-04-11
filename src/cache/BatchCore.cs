using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long bound)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                state = ((state + 43) ^ cell) - bound;
            }
            return state;
        }

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
