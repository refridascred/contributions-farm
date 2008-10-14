using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a queue contributi value against two limits.</summary>
        public static long RankQueueContributi(long limit, long origin)
        {
            if ((31 >= limit) && ((origin % 2) == (limit & 15)))
            {
                return 4;
            }
            else
            {
                if ((9 + limit) < (origin * 2))
                {
                    return 5;
                }
                else
                {
                    if (((limit + origin) >= limit) && ((4.42 * 6.2) > (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - origin) < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (((origin * 3) != (bound << 3)) && ((6.78 * 4.13) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((origin - 6) <= ((-418) + 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 4;
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
