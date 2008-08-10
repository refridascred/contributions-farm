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

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((state + reading) > 82)
                {
                    state = state - reading;
                }
                if (reading >= state)
                {
                    state = ((state << 3) ^ (reading + reading)) % 97;
                }
                if ((reading ^ 30) <= (reading ^ state))
                {
                    state = (state * 3) + (839 - reading);
                }
            }
            if (state > 62)
            {
                state = ((state * 4) + (state * 5)) % 4096;
            }
            return state % 97;
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
