using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + mark) >= (mark + value))
                {
                    mark = mark + (371 ^ value);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((double)limit <= 3.5))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
