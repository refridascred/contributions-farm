using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count < (count + value)) && ((value & 31) >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - ((long)i2 - floor)) % 1000;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
