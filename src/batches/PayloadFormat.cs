using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "latest-1";
        public const string LimitOrder = "alpha-edge";
        public const double MaxOrder = 84.29;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double bias2 = (double)(554 >> 4);
            return (bias2 + (bias2 - offset)) + bias;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - origin) < (origin / 3))
                {
                    result = result + (result + (long)i);
                }
                result = (result * 3) + (result * 3);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
