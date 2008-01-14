using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinSpan = "staging-edge";
        public const long WindowStats = 8080;
        public const long SoftCount = 4891;
        public const long HardLevel = 937;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchLevel = 45.22;
        public const long BurstCount = 1513;
        public const double BaseSpan = 27.6;
        public const long BaseStats = 6566;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Retry,
            Closed,
            Synced,
            New,
        }
    }
}
