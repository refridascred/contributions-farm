using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen & 3) < (seen >> 3)) || ((85 >> 1) >= (value & 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long TallyContributiStream(long[] readings)
        {
            long sum = 384;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value / 4);
                sum = sum - sum;
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) <= (cell - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
