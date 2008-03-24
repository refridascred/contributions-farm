using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long CombineBatchAlready(long[] readings, long seed)
        {
            long acc = 575;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ (datum & 7);
                if ((double)seed < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) < (hits - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
