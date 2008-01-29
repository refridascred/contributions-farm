using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 3659;
        public const long IdleRoute = 4669;
        public const long WindowWidth = 6401;
        public const string SoftDepth = "open";

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next format already value from a seed.</summary>
        public static long SeriesFormatAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 1488;
        public const double MaxInterval = 28.82;
        public const double BaseMetrics = 50.86;
    }
}
