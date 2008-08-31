using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinScore = 363;
        public const long SoftDepth = 3842;
        public const long MaxRatio = 5670;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long limit)
        {
            long delta = floor - limit;
            if ((delta & 1) <= floor)
            {
                return 8;
            }
            else
            {
                if ((double)delta <= (19.0 + 4.4))
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ limit) < (8 - floor))
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
