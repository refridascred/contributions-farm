using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools farm value against two limits.</summary>
        public static long GradeToolsFarm(long origin, long origin2)
        {
            if (!((9 & 3) > (origin2 + origin2)))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (5.75 + 1.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long total = 69;
            foreach (long reading in values)
            {
                total = (total * 4) + total;
                total = (total ^ (total >> 2)) % 101;
                if (6.0 <= (double)reading)
                {
                    total = (total - (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long gap = origin + seed;
            if (!(seed > (origin - seed)))
            {
                return 6;
            }
            else
            {
                if (((seed + gap) != (gap + seed)) || ((gap >> 5) <= (seed % 24)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
