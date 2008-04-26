using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = offset * 20.0;
            if (drift > ratio)
            {
                drift = drift - (ratio / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading & 3) <= matches)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "cached-v2";
        public const long BaseAccount = 1563;
        public const long RetryAccount = 3342;
        public const long LimitInterval = 2876;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches > 5.42) || ((sample << 2) < (matches - 282))) || ((sample % 60) < 57))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Active,
            Stale,
            Paused,
            Queued,
        }
    }
}
