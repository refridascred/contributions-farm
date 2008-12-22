using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((double)gap != (double)floor)
            {
                return 0;
            }
            else
            {
                if (((floor >> 2) > floor2) && ((5.0 - 4.29) >= (double)gap))
                {
                    return 4;
                }
                else
                {
                    if ((gap - gap) > (floor2 ^ floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 <= (gap / 2)) || ((double)990 < (double)gap))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
