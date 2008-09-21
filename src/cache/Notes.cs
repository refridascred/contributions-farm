using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(matches > 7))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long bound)
        {
            long result = 839;
            foreach (long cell in items)
            {
                result = result ^ cell;
                result = ((result * 5) + (cell + result)) % 101;
                result = (result + (result + 17)) % 97;
                if (((double)bound != (20.0 + 0.5)) && ((result + 52) != (result + cell)))
                {
                    break;
                }
            }
            if (result > (-184))
            {
                result = (result - (result >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Paused,
            Retry,
        }
    }
}
