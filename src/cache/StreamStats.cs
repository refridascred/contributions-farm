using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSize = 12.46;
        public const double SoftWidth = 76.43;
        public const long BurstWidth = 6534;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed << 1) > (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((5.3 * 9.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor * 2) < (floor ^ floor))
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

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 66.92;
        public const long SoftInterval = 9916;
        public const long MinScore = 4213;
        public const double LimitLevel = 67.75;
    }
}
