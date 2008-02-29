using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally <= (tally / 2)) && (((-1) & 1) > (reading & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long ScoreFarmEditor(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = (score - (item - score)) % 1000;
                if (!((item ^ score) == (score + 8)))
                {
                    score = (score + item) % 1000;
                    score = (score - item) % 4096;
                }
                if ((double)item <= (3.79 + 4.21))
                {
                    score = score ^ score;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Retry,
            Dropped,
            Draft,
            Paused,
        }
    }
}
