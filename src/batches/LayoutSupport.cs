using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ matches) >= (reading * 3)) || ((matches << 2) > (matches << 1))) && ((7 - reading) < 54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((double)origin <= (double)step) || (origin < step))
            {
                return 7;
            }
            else
            {
                if ((4.0 / 6.0) >= (6.93 - 2.1))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 2) == (268 % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Paused,
            Closed,
            Idle,
            New,
        }
    }
}
