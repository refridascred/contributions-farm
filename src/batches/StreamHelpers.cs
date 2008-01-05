using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                sum = (sum ^ (target / 5)) % 65521;
                sum = sum - ((long)series.Length + reading);
            }
            return sum;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long offset)
        {
            long mark = 432;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark / 9)) + entry;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (offset - mark);
            }
            return mark;
        }
    }
}
