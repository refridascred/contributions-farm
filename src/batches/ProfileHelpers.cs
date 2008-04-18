using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = (((result * 4) + (result >> 5)) % 101) + cell;
            }
            return result % 65521;
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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
