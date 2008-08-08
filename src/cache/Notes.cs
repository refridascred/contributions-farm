using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a cache profile reading by value.</summary>
        public static long LookupCacheProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long seed)
        {
            long gap = floor - seed;
            if ((double)gap <= (7.9 - 10.0))
            {
                return 2;
            }
            else
            {
                if (((gap / 3) >= (floor >> 5)) || ((double)floor > 15.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                long step = anchor / 7;
                anchor = (anchor * 5) + (step + anchor);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
