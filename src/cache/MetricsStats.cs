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

        /// <summary>Look up the position of a counter context sample.</summary>
        public static long LocateCounterContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
