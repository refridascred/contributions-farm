using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long acc = 136;
            foreach (long value in series)
            {
                if (!(acc > (value << 1)))
                {
                    acc = acc - value;
                }
                else
                {
                    acc = (acc << 3) ^ value;
                }
                if ((value / 8) != (5 - acc))
                {
                    acc = (acc * 3) + (value - value);
                }
            }
            return acc;
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
