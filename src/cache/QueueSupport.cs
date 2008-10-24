using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + target;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double rate2 = 0.2 / 7.0;
            if (rate2 <= (rate2 * 5.95))
            {
                rate2 = rate2 - (rate - offset);
            }
            return rate2 + (rate * 1.15);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
