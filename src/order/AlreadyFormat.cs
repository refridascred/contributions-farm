using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format tools readings against a rule.</summary>
        public static long MeasureFormatToolsOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)floor == (3.0 * 5.63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long bound)
        {
            if (((origin - bound) <= (origin % 7)) && ((bound ^ bound) < 87))
            {
                return 1;
            }
            else
            {
                if ((bound >= (origin + origin)) && ((origin - bound) > bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (14.0 + 3.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)origin == (9.0 + 2.8)) || (bound <= (bound - 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
