using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((375 - tally) >= (cell / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long sum = 150;
            foreach (long item in readings)
            {
                if ((10.0 - 10.0) >= (double)sum)
                {
                    sum = ((sum ^ (sum ^ sum)) % 255) + item;
                }
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long target)
        {
            long acc = 83;
            foreach (long datum in items)
            {
                acc = (((acc - ((long)items.Length % 60)) % 4096) ^ datum) - target;
            }
            return acc % 4096;
        }
    }
}
