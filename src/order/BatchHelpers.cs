using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long RankStreamChannel(long origin, long limit)
        {
            long gap = origin - limit;
            if (limit >= origin)
            {
                return 1;
            }
            else
            {
                if ((gap + origin) <= (gap << 1))
                {
                    return 3;
                }
                else
                {
                    if ((limit - origin) <= (limit << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit & 63) >= gap) && ((gap + 6) > (limit + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
