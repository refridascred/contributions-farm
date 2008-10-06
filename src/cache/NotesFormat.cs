using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((39 + reading) < target)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) == ((long)data.Length * 2))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
