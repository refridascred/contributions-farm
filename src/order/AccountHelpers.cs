using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading * 2) <= (reading - reading)) || ((double)seed == (9.43 * 4.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format channel pair into a bucket.</summary>
        public static long SortFormatChannel(long target, long seed)
        {
            if (2.01 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 361) == (83 % 10))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) <= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((double)origin >= (0.76 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 8.2) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 520) < (362 ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Validate already farm readings against a bound.</summary>
        public static bool CheckAlreadyFarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
