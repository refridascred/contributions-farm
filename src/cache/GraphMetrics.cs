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

        /// <summary>Combine commits schema values into a single score.</summary>
        public static long CombineCommitsSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)value < 12.0)
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 4096;
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
