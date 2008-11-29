using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Region { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the record window series from a seed.</summary>
        public static long SeriesRecordWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 96;
            foreach (long sample in levels)
            {
                carry = (carry - (carry - carry)) % 255;
                if ((carry / 4) >= (5 ^ carry))
                {
                    continue;
                }
                if ((sample >> 4) != (874 & 255))
                {
                    carry = carry - (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Queued,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
