using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 27.35;
        public const long BurstQueue = 8901;
        public const long CacheWidth = 3117;
        public const double BatchQueue = 74.62;
        public const long IdleLevel = 3883;

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long ScoreToolsLayout(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                if ((2.3 - 0.91) >= (double)value)
                {
                    carry = (carry ^ (carry % 10)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry & 63)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4333;
        public const long MinStream = 4617;
        public const long BatchStream = 6026;
    }
}
