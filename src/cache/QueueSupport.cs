using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score - (score << 3)) % 97) ^ cell;
            }
            if (score < 6)
            {
                score = score ^ (176 << 3);
            }
            return score;
        }
    }
}
