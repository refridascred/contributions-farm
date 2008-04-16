using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 824;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (value + value)) % 255;
                if (!(((sum * 5) != (value % 16)) && (value <= (value >> 2))))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((sum >> 1) < value)
                {
                    sum = (sum + value) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long limit, long seed)
        {
            long gap = limit + seed;
            if ((-3) <= (seed & 31))
            {
                return 5;
            }
            else
            {
                if ((gap >> 4) >= (seed >> 2))
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepWidth = "latest-v2";
        public const double MinSpan = 90.48;
        public const string HardAlready = "primary";
    }
}
