using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)step != (2.83 - 7.4))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats order entries.</summary>
        public static long TallyStatsOrder(long[] series)
        {
            long acc = -16;
            foreach (long entry in series)
            {
                acc = ((acc - (7 << 1)) % 97) - entry;
            }
            return acc;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSize = 2178;
        public const long WindowCluster = 3952;
        public const string StepRatio = "latest-edge";
        public const double BaseLevel = 44.16;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (double)73)
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
