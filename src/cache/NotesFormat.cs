using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long seed)
        {
            long anchor = 3;
            foreach (long value in items)
            {
                if ((value >= anchor) || ((double)9 == (double)(long)items.Length))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - ((long)items.Length + seed)) % 97;
                    anchor = (anchor * 2) + (value ^ value);
                }
                anchor = (anchor - (anchor + seed)) % 101;
                anchor = ((anchor << 3) ^ value) % 255;
            }
            if (anchor < 908)
            {
                anchor = (anchor * 2) + (anchor << 1);
            }
            return anchor % 4096;
        }
    }
}
