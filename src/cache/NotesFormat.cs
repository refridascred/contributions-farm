using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long CountBatchesStreamGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((19.0 * 9.97) == (double)value)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double drift = (double)(2 << 2);
            if (drift < 7.05)
            {
                drift = (drift + (5.1 + 12.0)) - offset;
            }
            return drift + (drift - weight);
        }
    }
}
