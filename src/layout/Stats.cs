using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Check that every booking entry stays within the limit.</summary>
        public static bool GuardBookingRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
