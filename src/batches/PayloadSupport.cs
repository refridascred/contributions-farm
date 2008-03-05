using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 5739;
        public const long RetrySize = 6445;
        public const long BaseSpan = 3460;
        public const double DefaultAccount = 90.17;

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > (bias - weight))
            {
                ratio = ratio - (weight / 8.0);
            }
            return ratio + bias;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step - 394) >= (step & 63))
                {
                    total = total - (step << 2);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
