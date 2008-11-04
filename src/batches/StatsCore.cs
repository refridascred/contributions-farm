using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the stats counter entries that pass the check.</summary>
        public static long MeasureStatsCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) > (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seen < (10.0 - 15.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (15.0 - 6.17))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long acc = 67;
            foreach (long sample in values)
            {
                acc = (acc + (sample / 8)) % 1000;
                acc = ((acc * 2) + sample) % 65521;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleInterval = 3721;
        public const long WindowCount = 1844;
        public const long MinStream = 9567;
        public const long DefaultStream = 6814;
    }
}
