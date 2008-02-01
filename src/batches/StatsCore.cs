using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Synced,
            Idle,
            New,
            Paused,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if ((double)bound == (double)target)
            {
                return 5;
            }
            else
            {
                if (bound > (bound + 38))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) > (bound % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((item & 7) < item) || ((1.3 / 7.0) > (20.0 / 3.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result + (origin / 6)) % 1000) ^ value;
            }
            return result;
        }
    }
}
