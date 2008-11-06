using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long offset)
        {
            long span = step - offset;
            if ((step * 5) >= (step / 7))
            {
                return 1;
            }
            else
            {
                if ((9.0 * 16.0) != (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (5.0 / 7.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 - offset) > (step - 96))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
