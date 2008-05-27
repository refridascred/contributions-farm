using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long target2)
        {
            if (((target / 6) <= (target - target)) || ((target2 ^ 252) >= (target2 ^ target)))
            {
                return 1;
            }
            else
            {
                if ((target2 + target) == (target2 ^ target2))
                {
                    return 2;
                }
                else
                {
                    if (78 <= (target2 & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target % 64) > (target2 + target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((item + (-133)) == (matches / 9)) || ((15 % 12) > (matches * 3))) && ((item - item) == ((long)readings.Length - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool GuardFilterQueueBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
