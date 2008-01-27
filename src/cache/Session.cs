using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 5628;
        public const long CacheSize = 6184;
        public const long BatchTimeout = 6898;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ 42;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long GradeContributiRoute(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (floor2 > (delta >> 2))
            {
                return 7;
            }
            else
            {
                if (floor <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (double)42)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor2 != (3.17 / 6.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order schema sample.</summary>
        public static long LookupOrderSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
