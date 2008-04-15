using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            New,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "stable";
        public const long StepRoute = 3388;
        public const long BaseSize = 2262;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double gain = span + (span / 9.0);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)(-81)) - (double)(long)i) + weight;
            }
            return gain + (span * 16.0);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((2 * 2) < cell)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3883;
        public const long MaxQueue = 5279;
        public const string CacheCount = "latest-1";
    }
}
