using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 88.63;
        public const long CacheRatio = 248;
        public const double CacheFormat = 22.42;

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftTimeout = "staging";
        public const string MinSpan = "local-1";
        public const long WindowBudget = 5700;
        public const double CacheRoute = 74.82;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (!(9 < bound))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 546) <= (gap / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap + gap) > (offset << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
