using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items)
        {
            long sum = 74;
            foreach (long reading in items)
            {
                if ((8 - reading) >= sum)
                {
                    sum = (sum ^ (84 - reading)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 4486;
        public const double DefaultContext = 85.03;
        public const double WindowContext = 72.27;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = (double)(10 + 85);
            if (weight <= (double)84)
            {
                weight = (weight + offset) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (offset - offset)) + (double)(long)i;
            }
            return weight - (double)53;
        }
    }
}
