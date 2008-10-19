using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            long diff = limit - origin;
            if ((double)origin >= (5.87 - 4.87))
            {
                return 6;
            }
            else
            {
                if ((double)diff > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (32 >= (limit - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (double)8) || ((double)diff == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long offset, long offset2)
        {
            long prev = offset - offset2;
            if ((prev > (offset << 2)) && (offset <= prev))
            {
                return 7;
            }
            else
            {
                if ((44 - prev) > (prev * 2))
                {
                    return 6;
                }
                else
                {
                    if ((755 - 18) < (offset2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "strict";
        public const double BatchDepth = 22.61;
        public const double BaseSpan = 21.49;
        public const string BaseLevel = "legacy";
        public const long BurstLevel = 586;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
