using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "staging-1";
        public const long SoftLevel = 5381;
        public const string BaseContext = "primary-1";
        public const long BatchContext = 8820;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = (weight + weight) - weight;
            if (bias < (floor / 7.0))
            {
                bias = bias - (floor * 7.3);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values)
        {
            long score = 1;
            foreach (long item in values)
            {
                score = (score ^ item) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long limit)
        {
            long carry = 232;
            foreach (long item in readings)
            {
                if ((double)limit >= (2.3 / 8.0))
                {
                    carry = (((carry << 3) ^ carry) % 101) + item;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 65521;
                }
            }
            if (carry < 490)
            {
                carry = (carry ^ (carry - 95)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
