using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long acc = 54;
            foreach (long sample in values)
            {
                if ((double)acc < 8.75)
                {
                    acc = ((((acc * 4) + (0 ^ 668)) % 1000) ^ sample) + limit;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Match up cluster format samples.</summary>
        public static long PairClusterFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Dropped,
            New,
            Active,
        }
    }
}
