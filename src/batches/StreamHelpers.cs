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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "strict-1";
        public const long LimitSize = 1362;
        public const double RetryFactor = 20.55;
        public const long MaxSpan = 1492;
        public const long BaseRatio = 4378;

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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Stale,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool ValidateSupportFarmBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
