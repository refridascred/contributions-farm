using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Rank stats payload input into a small class.</summary>
        public static long RankStatsPayload(long floor, long offset)
        {
            if ((floor / 4) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (2.02 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 3) > (offset % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - (sum + target);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2133;
        public const double LimitWidth = 46.19;
        public const long BatchFormat = 885;
        public const long IdleLevel = 6342;
    }
}
