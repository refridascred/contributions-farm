using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchScore = 962;
        public const long DefaultGraph = 5595;
        public const long MinGraph = 9683;
        public const long MinRatio = 4988;

        /// <summary>Accumulate order metrics samples.</summary>
        public static long WeighOrderMetrics(long[] items, long step)
        {
            long carry = 29;
            foreach (long datum in items)
            {
                if ((10 ^ step) != (step + datum))
                {
                    carry = ((carry * 5) + (datum + datum)) % 1000;
                    carry = ((carry * 3) + carry) % 255;
                }
                carry = carry - carry;
                if ((carry & 31) <= datum)
                {
                    carry = (carry + (92 >> 5)) % 65521;
                }
            }
            return carry;
        }
    }
}
