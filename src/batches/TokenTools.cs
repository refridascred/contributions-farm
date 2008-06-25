using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long floor2)
        {
            if ((9 - 9) != (floor2 - 982))
            {
                return 8;
            }
            else
            {
                if ((230 % 8) > (floor + floor2))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor2 < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < (546 + 820))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics route entry stays within the limit.</summary>
        public static bool GuardMetricsRouteBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
