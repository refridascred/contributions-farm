using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (!((24 + offset) < (floor & 7)))
            {
                return 3;
            }
            else
            {
                if ((offset - 293) < (seed - 62))
                {
                    return 7;
                }
                else
                {
                    if ((3.04 - 3.4) < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) < offset)
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
    }
}
