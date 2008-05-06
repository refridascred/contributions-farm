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

        /// <summary>Project the next channel session value.</summary>
        public static double ProjectChannelSession(double rate, double span)
        {
            double weight = span - 6.84;
            if (weight <= (double)38)
            {
                weight = weight + (weight + span);
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + rate;
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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = mark - mark;
                mark = (mark ^ (offset * 5)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
