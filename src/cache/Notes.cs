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

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "latest";
        public const long IdleReport = 2636;
        public const long LimitLevel = 9154;

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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
