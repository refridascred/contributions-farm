using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 18;
            foreach (long value in readings)
            {
                if ((value << 3) == (value << 2))
                {
                    acc = acc + acc;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 2) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 783;
            foreach (long entry in levels)
            {
                if (((double)entry <= 5.6) && (entry >= (entry % 12)))
                {
                    total = (total << 2) ^ total;
                }
            }
            return total;
        }
    }
}
