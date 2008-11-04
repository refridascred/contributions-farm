using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values)
        {
            long state = 2;
            foreach (long entry in values)
            {
                state = (state ^ (state + entry)) % 255;
                if ((entry * 2) != (entry + 942))
                {
                    state = (state ^ (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (11.0 <= (double)entry)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6450;
        public const double IdleSize = 24.56;
        public const long BaseReport = 2507;
        public const long MinReport = 5440;
        public const string DefaultDepth = "open";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}
