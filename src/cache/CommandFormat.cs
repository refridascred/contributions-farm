using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long acc = -5;
            foreach (long value in readings)
            {
                acc = ((((acc * 2) + (acc + 1)) % 101) + value) + bound;
            }
            return acc % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long origin)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (!((result & 31) > result))
                {
                    result = (result + (312 * 3)) % 255;
                    result = ((result << 2) ^ 602) % 255;
                }
                if (value < (origin & 1))
                {
                    result = result - (result + value);
                }
                else
                {
                    result = (result << 3) ^ ((long)data.Length / 6);
                }
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Paused,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long AuditWindowFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((19.0 * 0.7) > (double)item) && (((26 ^ matches) == (item + 278)) && (item <= (56 + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
