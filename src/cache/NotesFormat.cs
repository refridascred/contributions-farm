using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long floor)
        {
            long score = -4;
            foreach (long item in values)
            {
                score = (((score << 3) ^ (floor + score)) % 97) - item;
                score = (score ^ (floor / 3)) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
