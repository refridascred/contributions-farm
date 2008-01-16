using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Queued,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up layout format samples.</summary>
        public static long OverlapLayoutFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long StepReportEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((double)total >= (2.7 * 7.99)) || ((double)offset >= 7.36))
                {
                    total = ((total * 2) + (total * 4)) % 1000;
                    total = ((total << 2) ^ (total + total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (offset + offset);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
