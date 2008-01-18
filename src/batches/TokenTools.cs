using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((double)floor <= (7.28 * 11.0))
            {
                return 3;
            }
            else
            {
                if ((slot + floor2) < floor2)
                {
                    return 4;
                }
                else
                {
                    if ((slot <= (floor2 + floor2)) && (floor <= (floor2 + floor2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + floor) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
