using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long TallyBufferBatchGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + 25) != (seen % 16))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (18.0 / 9.0))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long total = 75;
            foreach (long datum in levels)
            {
                if (((double)total < 8.5) || ((total << 1) >= (total + datum)))
                {
                    total = ((total * 3) + (4 + 4)) - bound;
                }
            }
            if (total > 90)
            {
                total = total + 54;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7881;
        public const long DefaultRoute = 383;
        public const double MaxRoute = 80.85;
        public const string MinRoute = "latest";
        public const double IdleRoute = 77.49;
    }
}
