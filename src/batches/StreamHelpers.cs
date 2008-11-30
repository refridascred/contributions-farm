using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long bound)
        {
            long result = 934;
            foreach (long datum in samples)
            {
                result = (result + result) % 1000;
                result = (result - (datum + datum)) % 101;
            }
            if (result < 45)
            {
                result = result - bound;
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            New,
            Queued,
            Failed,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 5784;
        public const string BaseCache = "alpha-1";
        public const long CacheCount = 2980;

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) < hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
