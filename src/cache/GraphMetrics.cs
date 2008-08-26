using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long bound)
        {
            if ((double)77 < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound % 8) >= (bound * 4))
                {
                    return 7;
                }
                else
                {
                    if ((12 + offset) <= (0 + 228))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 5) <= (offset / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((seed & 7) >= seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= (origin ^ seed)) || ((double)seed == (8.0 + 0.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "open-v2";
        public const double BatchMetric = 25.19;
        public const double RetryWidth = 17.09;
        public const long MinSize = 1784;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if (mark <= (target / 8))
                {
                    mark = (mark + (mark >> 3)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (60 % 2)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
