using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            long delta = limit + limit2;
            if ((45 + delta) < (delta + 642))
            {
                return 1;
            }
            else
            {
                if ((7.2 - 4.57) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((limit - limit) >= (delta - delta)) && ((limit << 3) <= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit2 ^ 176) < (delta * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long target)
        {
            if (!((double)origin < (16.0 - 0.4)))
            {
                return 8;
            }
            else
            {
                if (((target << 1) < target) && ((13.0 - 7.25) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((origin % 10) >= (origin + target))
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
