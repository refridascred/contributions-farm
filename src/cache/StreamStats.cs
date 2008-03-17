using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long RollToolsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 3) + (sum ^ sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long bound)
        {
            long delta = origin + bound;
            if ((848 % 64) < (bound + origin))
            {
                return 0;
            }
            else
            {
                if ((delta - origin) < (origin & 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin <= (double)bound) && ((773 % 12) < delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((delta ^ origin) > ((-597) * 4)) || (delta < (delta - (-862))))
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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "latest-edge";
        public const long HardLevel = 6543;
        public const string CacheWidth = "standard-edge";
        public const long BurstLevel = 9337;
    }
}
