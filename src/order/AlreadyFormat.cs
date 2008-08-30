using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long TallyOrderSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) <= 11)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Find the first schema tools entry that matches the target.</summary>
        public static long LookupSchemaToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
