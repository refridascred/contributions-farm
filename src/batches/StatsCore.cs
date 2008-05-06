using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter farm readings against a rule.</summary>
        public static long TallyCounterFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((9.41 / 3.0) < (double)value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph githubfarm readings.</summary>
        public static long ScoreGraphGithubfarm(long[] series)
        {
            long score = 40;
            foreach (long sample in series)
            {
                score = ((score + (score - score)) % 4096) - sample;
            }
            return score;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.0 / 8.0) < (double)seed)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Closed,
            Idle,
            Queued,
        }
    }
}
