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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
