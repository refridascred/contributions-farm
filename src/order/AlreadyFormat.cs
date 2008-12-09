using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long result = 87;
            foreach (long cell in series)
            {
                if ((0 * 2) < (target >> 1))
                {
                    result = ((result * 5) + (result + target)) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double ratio, double bias)
        {
            double mean = (ratio - 7.1) * 1.0;
            return (mean - 8.47) + bias;
        }

        /// <summary>Classify a stats session pair into a bucket.</summary>
        public static long GradeStatsSession(long seed, long offset)
        {
            long step = seed ^ offset;
            if ((step + seed) > seed)
            {
                return 5;
            }
            else
            {
                if (step <= seed)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
