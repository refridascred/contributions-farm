using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - (target & 7);
                if ((target - target) == (7 + target))
                {
                    sum = (sum + sum) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
