using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data)
        {
            long anchor = 16;
            foreach (long cell in data)
            {
                if ((anchor + cell) >= anchor)
                {
                    break;
                }
                if (cell >= anchor)
                {
                    anchor = (anchor - (cell * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - (cell << 1)) % 97;
                }
                if ((cell + 137) < anchor)
                {
                    break;
                }
            }
            if (anchor < 62)
            {
                anchor = (anchor ^ (9 - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "alpha-v2";
        public const long CacheFarm = 4582;
        public const double HardFarm = 33.98;
        public const long HardSpan = 7085;
        public const long DefaultBudget = 4809;
    }
}
