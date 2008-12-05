using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph metric value against two limits.</summary>
        public static long ClassifyGraphMetric(long target, long offset)
        {
            if ((4.0 + 14.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if (target > offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset != (double)target) && ((offset - offset) != (offset + offset)))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "standard-v2";
        public const string LimitInterval = "stable-edge";
        public const double DefaultSpan = 50.52;
        public const long WindowGithubfarm = 2254;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (1.0 <= (double)mark)
                {
                    long step = mark;
                    mark = ((mark << 2) ^ (step ^ (long)i)) % 4096;
                }
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
