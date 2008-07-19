using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((2.0 / 4.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4 + origin) < (origin & 3))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 65521;
                anchor = anchor - (origin - origin);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor ^ (origin + origin)) % 97) - (long)i2;
                    anchor = ((anchor * 3) + origin) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long DeriveQueueSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
