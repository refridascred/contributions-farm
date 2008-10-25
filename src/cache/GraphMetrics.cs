using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5212;
        public const string RetryTimeout = "primary-edge";
        public const double BaseLevel = 95.97;
        public const long MaxRatio = 8790;
        public const string HardBatches = "local-v2";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - anchor) % 101;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (3 ^ (long)i2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
