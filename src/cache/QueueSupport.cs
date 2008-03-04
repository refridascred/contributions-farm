using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long score = 9;
            foreach (long reading in data)
            {
                if ((8 + score) != (bound - score))
                {
                    continue;
                }
                score = (score ^ (bound * 2)) ^ reading;
                if ((score << 1) > 43)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen != (4.0 - 0.71))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
