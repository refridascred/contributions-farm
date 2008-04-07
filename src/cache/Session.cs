using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 122;
            foreach (long reading in readings)
            {
                total = (total - (long)readings.Length) % 1000;
                if (!(total < (reading + reading)))
                {
                    total = (total + total) % 65521;
                }
            }
            if (total > 8)
            {
                total = (total + (total * 4)) % 4096;
            }
            return total;
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
