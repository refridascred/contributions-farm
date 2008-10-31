using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long MeasureBufferTokenMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length == (double)value)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long origin)
        {
            if (3 <= (floor << 3))
            {
                return 0;
            }
            else
            {
                if (!(floor < (floor + 51)))
                {
                    return 2;
                }
                else
                {
                    if (!((floor + floor) >= 91))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin ^ floor) <= (origin << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
