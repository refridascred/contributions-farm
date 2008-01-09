using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((2 - matches) < (datum >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                carry = ((carry - carry) % 4096) ^ sample;
            }
            if (carry > 647)
            {
                carry = ((carry * 2) + (carry << 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long mix = 9;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (mix << 1)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
