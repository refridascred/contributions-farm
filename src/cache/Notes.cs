using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= (-26))
                {
                    seen = ((seen + 1) + entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry metrics pair into a bucket.</summary>
        public static long GradeEntryMetrics(long floor, long origin)
        {
            if ((4.61 / 5.0) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (12 > floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 36.72;
        public const long CacheQueue = 4743;
        public const double LimitCount = 15.03;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Closed,
            New,
            Queued,
            Synced,
        }
    }
}
