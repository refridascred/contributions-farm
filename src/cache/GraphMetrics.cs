using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + ((long)i + offset)) % 4096;
                carry = carry ^ carry;
                if ((double)offset >= (9.0 * 6.3))
                {
                    carry = (carry ^ (carry - (long)i)) % 4096;
                    carry = carry + ((long)i + offset);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
