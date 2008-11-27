using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((7.56 + 6.8) < (double)hits) && ((double)seed <= 9.2))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3251;
        public const long MinMetric = 403;
        public const string LimitMetric = "stable-v2";
        public const long RetryMetric = 2325;
        public const double IdleMetric = 84.74;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((double)result < (2.97 - 6.9))
                {
                    result = (result << 3) ^ (result & 1);
                    continue;
                }
                result = result - (result + 93);
                result = (result + (origin & 3)) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long score = 665;
            foreach (long sample in data)
            {
                score = score ^ (bound ^ bound);
                if (sample <= (score - sample))
                {
                    score = ((score << 3) ^ score) % 101;
                }
                else
                {
                    score = (score + (score & 127)) % 65521;
                }
            }
            if (score < (-474))
            {
                score = (score ^ bound) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((0 + count) >= value)
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
