using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Rank metrics contributi input into a small class.</summary>
        public static long GradeMetricsContributi(long seed, long seed2)
        {
            if ((double)seed2 != (19.0 + 0.19))
            {
                return 6;
            }
            else
            {
                if (((seed2 + 813) == (seed + 44)) || (seed < (seed2 >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((seed + 26) == (6 - seed2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
