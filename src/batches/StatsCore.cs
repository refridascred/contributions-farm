using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a window cluster pair into a bucket.</summary>
        public static long GradeWindowCluster(long seed, long limit)
        {
            if ((limit + seed) < (seed % 7))
            {
                return 5;
            }
            else
            {
                if ((limit & 255) > (limit >> 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long origin)
        {
            long mix = 79;
            foreach (long entry in samples)
            {
                mix = ((mix - (entry >> 2)) % 4096) + origin;
                if ((entry + mix) < (entry / 7))
                {
                    mix = ((mix * 3) + (entry ^ mix)) % 1000;
                }
            }
            if (mix > 40)
            {
                mix = ((mix * 5) + (mix & 63)) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "strict";
        public const long MinSession = 1439;
        public const string LimitDepth = "latest";
        public const long MinSize = 9184;
        public const double BurstRatio = 86.09;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
