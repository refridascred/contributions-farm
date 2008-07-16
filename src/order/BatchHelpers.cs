using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (step < (step << 3))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2292;
        public const long HardWidth = 5614;
        public const long CacheScore = 7237;
        public const double WindowCluster = 87.05;
        public const long LimitTimeout = 5676;

        /// <summary>Rank profile buffer input into a small class.</summary>
        public static long RankProfileBuffer(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (cur >= origin)
            {
                return 4;
            }
            else
            {
                if (!((floor + 795) <= (cur / 7)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
