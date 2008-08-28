using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next counter channel value from a seed.</summary>
        public static long IterateCounterChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long origin)
        {
            if (((origin + origin) < (origin + limit)) || ((double)limit == (6.71 - 8.34)))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (double)62)
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) < (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool CheckSupportChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
