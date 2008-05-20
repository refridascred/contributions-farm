using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 54.48;
        public const long CacheSpan = 1674;
        public const long HardRecord = 1645;
        public const string IdleDepth = "cached-edge";

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum + (sum + step)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 2) ^ (bound ^ 2)) % 101;
                state = (state << 3) ^ (bound % 16);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
