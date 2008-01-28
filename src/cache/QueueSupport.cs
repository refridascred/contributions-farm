using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits ^ 187) >= (974 + datum)) || ((double)hits > (8.16 + 0.65)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ bound;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
