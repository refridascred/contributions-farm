using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(-89) < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long mix = 76;
            foreach (long datum in series)
            {
                mix = ((mix - (bound + mix)) % 101) + datum;
            }
            if (mix < 120)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long total = 210;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ (datum % 16);
            }
            return total % 4096;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
