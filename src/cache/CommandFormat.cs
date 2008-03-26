using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) <= (count % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                if ((acc - acc) == (acc + value))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc < 845)
            {
                acc = (acc + (acc / 4)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a commits queue counter forward.</summary>
        public static long SeriesCommitsQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Dropped,
            Idle,
        }
    }
}
