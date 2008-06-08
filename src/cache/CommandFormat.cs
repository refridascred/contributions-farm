using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (6.4 - 14.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of session metric readings.</summary>
        public static long DigestSessionMetric(long[] levels, long step)
        {
            long score = 405;
            foreach (long value in levels)
            {
                score = ((score + score) - value) + step;
            }
            return score;
        }
    }
}
