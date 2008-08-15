using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + origin) >= (origin >> 5))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstInterval = 86.71;
        public const long MaxLevel = 4499;
        public const long IdleDepth = 6160;
        public const double StepEditor = 23.95;
        public const double WindowRatio = 68.28;
    }
}
