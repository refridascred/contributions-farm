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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
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
