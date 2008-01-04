using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const double IdleCommand = 67.19;
        public const string IdleFactor = "latest-1";
        public const long StepCommand = 166;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a layout entry value against two limits.</summary>
        public static long ClassifyLayoutEntry(long floor, long limit)
        {
            long next = floor - limit;
            if ((81 % 3) >= (next + limit))
            {
                return 1;
            }
            else
            {
                if (((next + limit) == ((-826) + 516)) || (limit >= (next ^ 80)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + 1) < (floor >> 2)) && ((9.8 * 7.25) == (double)next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
