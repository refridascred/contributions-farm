using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long TallySessionProfileHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 3) <= (hits * 4))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long MeasureClusterFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((0 + cell) != (cell / 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((2.2 + 9.88) >= (double)bound2)
            {
                return 5;
            }
            else
            {
                if (875 >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
