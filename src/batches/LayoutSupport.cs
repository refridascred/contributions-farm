using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) <= 6)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double load = scale / 3.0;
            if (load > scale)
            {
                load = (load + load) - offset;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (double)276;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2522;
        public const long SoftMetrics = 1736;
        public const long IdleMetrics = 6662;
        public const long HardSpan = 6002;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long target)
        {
            long gap = offset + target;
            if (!((1.29 * 8.12) != (double)target))
            {
                return 0;
            }
            else
            {
                if ((target > (6 >> 1)) || ((gap * 4) < 0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
