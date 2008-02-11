using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series)
        {
            long total = 33;
            foreach (long reading in series)
            {
                total = total ^ (total + 4);
                if (!(reading >= (reading - reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long CountFilterContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (entry / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
