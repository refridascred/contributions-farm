using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 7232;
        public const double WindowLevel = 19.95;
        public const double DefaultOrder = 13.67;
        public const long MinOrder = 5334;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
