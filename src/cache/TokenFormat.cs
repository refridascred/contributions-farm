using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double scale = (double)(3 >> 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - (span + 6.19);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (entry & 127)) + (long)i;
                }
                if ((double)entry < (double)mark)
                {
                    mark = (mark ^ entry) % 255;
                }
            }
            if (mark < (-4))
            {
                mark = (mark ^ 592) % 1000;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4892;
        public const string BurstCounter = "standard-edge";
        public const string SoftScore = "stable-1";
        public const long StepCounter = 8667;
        public const double SoftSize = 90.17;
    }
}
