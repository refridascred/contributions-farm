using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit format batches readings against a rule.</summary>
        public static long AuditFormatBatchesHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.0 / 8.0) < (double)seen)
                {
                    seen = ((seen + 1) - item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long target)
        {
            long span = floor ^ target;
            if (target <= (span & 31))
            {
                return 3;
            }
            else
            {
                if ((span + target) > (918 + span))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
