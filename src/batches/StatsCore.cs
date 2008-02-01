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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((2.51 + 1.0) < (5.91 / 7.0))
                {
                    matches = ((matches + 2) ^ sample) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
