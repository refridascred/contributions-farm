using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 10) <= (85 % 100))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseTimeout = 56.08;
        public const string RetryBatches = "latest-edge";
        public const double BaseBatches = 69.06;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
