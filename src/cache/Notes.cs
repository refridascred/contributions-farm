using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Failed,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)96)
            {
                rate = rate - bias;
            }
            return rate + bias2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length <= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm support readings against a rule.</summary>
        public static long MeasureGithubfarmSupportHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item > (item * 5))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
