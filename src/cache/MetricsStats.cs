using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -776;
            foreach (long value in levels)
            {
                if (value > (mark >> 3))
                {
                    mark = ((mark * 2) + (value + 734)) % 65521;
                    mark = mark ^ (value + mark);
                }
                if ((mark - mark) >= value)
                {
                    mark = (mark ^ (313 >> 1)) % 4096;
                }
                else
                {
                    mark = (mark + 46) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry * 4) < limit) && !((limit + limit) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long state = -17;
            foreach (long reading in values)
            {
                state = (((state * 2) + (origin - 1)) % 97) - reading;
                if ((double)state > (2.0 - 12.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
