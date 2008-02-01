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

        /// <summary>Rank format channel input into a small class.</summary>
        public static long RankFormatChannel(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((slot / 2) != (limit << 2))
            {
                return 4;
            }
            else
            {
                if (((double)limit <= 3.8) && ((limit ^ 6) >= slot))
                {
                    return 1;
                }
                else
                {
                    if ((seed < (limit - 49)) && ((limit >> 4) >= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
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
