using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the entry token series from a seed.</summary>
        public static long DeriveEntryToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 2) + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) == (floor >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
