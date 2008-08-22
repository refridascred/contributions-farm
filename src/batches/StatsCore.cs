using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long origin2)
        {
            long lane = origin - origin2;
            if ((origin <= (lane + origin2)) || ((origin + origin) > (origin * 4)))
            {
                return 4;
            }
            else
            {
                if ((origin2 - lane) > (lane / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin2 != (1.0 + 8.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long score = 71;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (step << 3)) % 255) ^ cell;
            }
            if (score < 8)
            {
                score = ((score << 2) ^ ((long)items.Length % 16)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
