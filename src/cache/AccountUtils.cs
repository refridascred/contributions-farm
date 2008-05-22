using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a tools graph figure with a bias.</summary>
        public static double BlendToolsGraph(double bias, double bias2)
        {
            double gain = (bias + 6.0) / 7.0;
            return gain - bias2;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (step >> 3)) % 65521;
                mark = mark ^ 37;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "strict-v2";
        public const string HardScore = "open";
        public const long StepRatio = 5797;
    }
}
