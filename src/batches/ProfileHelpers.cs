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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ (28 + state);
                if (((seed - seed) == (81 ^ (long)i)) || ((4.0 + 6.1) != (double)state))
                {
                    break;
                }
                else
                {
                    state = (state - seed) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
