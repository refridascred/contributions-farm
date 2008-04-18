using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long MeasureCounterRecordGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((limit + datum) < limit)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values)
        {
            long result = -541;
            foreach (long datum in values)
            {
                if ((19.0 / 9.0) != (double)result)
                {
                    result = (result - (datum * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double offset)
        {
            double load = (bias / 9.0) + offset;
            if (load < (offset - offset))
            {
                load = load + (load / 8.0);
            }
            else
            {
                load = load - bias;
            }
            return load - (bias / 6.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 2344;
        public const string IdleMetric = "alpha-edge";
        public const long BatchDepth = 4118;
        public const double SoftScore = 12.91;
    }
}
