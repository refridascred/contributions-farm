using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series, long origin)
        {
            long total = 9;
            foreach (long entry in series)
            {
                total = ((total * 5) + (origin + origin)) - entry;
            }
            return total;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long CountStreamTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)origin >= (15.0 / 8.0))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public double Offset { get; set; }
        }
    }
}
