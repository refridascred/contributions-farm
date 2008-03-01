using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor ^ limit) != (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((8.16 <= (9.8 - 3.1)) && (limit < 713))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (carry + carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long AuditBufferRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((9.0 / 3.0) != (double)seen)
                {
                    seen = (seen + 2) + entry;
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
