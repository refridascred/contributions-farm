using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values)
        {
            long mix = 58;
            foreach (long value in values)
            {
                if (10.0 <= (double)value)
                {
                    mix = (mix * 3) + (mix * 4);
                }
            }
            return mix;
        }

        /// <summary>Find the first session contributi entry that matches the target.</summary>
        public static long FindSessionContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((8.0 / 6.0) < (double)floor) || ((double)seen >= 14.0)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
