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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long bound)
        {
            if ((double)seed > (7.06 * 9.3))
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) > (bound - bound)) && ((bound + bound) < (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) < (0 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 0) == (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 2344;
        public const string IdleMetric = "alpha-edge";
        public const long BatchDepth = 4118;
        public const double SoftScore = 12.91;
    }
}
