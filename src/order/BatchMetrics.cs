using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long AuditCommitsFarmGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 2) > cell)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor commits entry that matches the target.</summary>
        public static long LookupEditorCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (5 - origin)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample * 4) != (origin * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long mix = 41;
            foreach (long datum in items)
            {
                if (mix <= (mix + mix))
                {
                    mix = (((mix * 2) + (mix - 7)) % 255) - datum;
                }
            }
            if (mix > 48)
            {
                mix = ((mix << 3) ^ ((long)items.Length - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 1226;
        public const long LimitSize = 1336;
        public const long MinWidth = 8782;
        public const long SoftTimeout = 458;
        public const long BurstInterval = 7847;
    }
}
