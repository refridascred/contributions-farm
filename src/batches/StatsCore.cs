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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= (hits % 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double weight = floor;
            return weight - bias;
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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
