using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if (((double)prev < (double)origin) && ((limit << 2) < (origin ^ (-27))))
            {
                return 2;
            }
            else
            {
                if ((origin - limit) == (prev + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (6.9 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2 ^ origin) >= (limit % 12)) || ((prev / 6) > (origin + prev)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count & 31))
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)target <= 2.0)
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long LookupEditorChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command order input into a small class.</summary>
        public static long BucketCommandOrder(long floor, long floor2)
        {
            long delta = floor + floor2;
            if ((delta / 4) < (floor2 / 7))
            {
                return 6;
            }
            else
            {
                if (!(floor2 < (delta + delta)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
