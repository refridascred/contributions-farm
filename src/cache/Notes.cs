using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Closed,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double scale = weight;
            if (scale > span)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (double)3;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long floor)
        {
            long prev = bound + floor;
            if (!((floor & 1) < prev))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (5.3 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((2.9 - 19.0) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((61 ^ floor) <= (bound % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7534;
        public const string BurstSession = "staging";
        public const long WindowWidth = 5042;
        public const long MaxDepth = 2261;
        public const long CacheSession = 7465;
    }
}
