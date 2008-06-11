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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long score = 736;
            foreach (long reading in readings)
            {
                if (!(limit < (reading >> 1)))
                {
                    score = score + (48 % 7);
                }
                else
                {
                    score = (score - (limit << 1)) % 4096;
                }
            }
            if (score > 63)
            {
                score = score + (score ^ score);
            }
            return score % 65521;
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
