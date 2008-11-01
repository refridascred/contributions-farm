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

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
