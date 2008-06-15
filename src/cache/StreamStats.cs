using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long GradeFarmSchema(long origin, long offset)
        {
            if ((offset - origin) < offset)
            {
                return 6;
            }
            else
            {
                if (!((9.45 * 3.83) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 5) > origin) || (origin < (0 - 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset << 2) > (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinScore = "primary-edge";
        public const double LimitFactor = 34.42;
        public const string BatchCount = "alpha-edge";
        public const double WindowRatio = 91.23;
        public const long LimitTimeout = 5018;
    }
}
