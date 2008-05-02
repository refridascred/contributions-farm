using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long CountWindowMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 / 5) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order context value from a seed.</summary>
        public static long SeriesOrderContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (796 + origin)) % 255;
                if (!((carry << 2) < ((long)i >> 2)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
