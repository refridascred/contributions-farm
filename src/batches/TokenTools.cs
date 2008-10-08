using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] data, long floor)
        {
            long mix = 984;
            foreach (long sample in data)
            {
                mix = (mix + (mix ^ mix)) - sample;
                mix = (mix - mix) % 97;
                mix = (mix * 4) + (floor + mix);
            }
            return mix % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3673;
        public const long MinFactor = 3145;
        public const long BatchFormat = 2053;
        public const long HardFormat = 909;
        public const long SoftRatio = 1110;

        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double ScaleContributiTools(double rate, double span)
        {
            double ratio = (double)43 + (double)9;
            if (ratio > span)
            {
                ratio = ratio + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (rate - ratio)) + (double)(long)i;
            }
            return ratio - (double)63;
        }
    }
}
