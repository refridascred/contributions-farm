using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 53.71;
        public const long WindowFactor = 6056;
        public const long MaxTimeout = 4033;
        public const long WindowContributi = 2124;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 4;
            foreach (long value in data)
            {
                total = (((total * 2) + (total ^ total)) % 65521) ^ value;
            }
            if (total < 128)
            {
                total = (total << 3) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
