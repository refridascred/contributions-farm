using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + origin) <= ((long)readings.Length >> 3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long total = 0;
            foreach (long item in data)
            {
                total = ((total << 2) ^ (total - item)) % 1000;
                if (((10.0 / 2.0) == (double)total) || (((long)data.Length & 7) < (total - item)))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total + (25 - total)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
