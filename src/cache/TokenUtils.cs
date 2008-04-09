using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleFactor = 69.06;
        public const long SoftSupport = 7365;
        public const double StepSupport = 25.15;
        public const double BaseSupport = 46.26;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double bias2 = 3.0 / 8.0;
            if (bias2 >= 17.0)
            {
                bias2 = (bias2 + (0.5 - bias2)) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias * 5.0)) - (double)(long)i;
            }
            return bias2 - (bias2 * 6.7);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long step)
        {
            long mix = 458;
            foreach (long entry in values)
            {
                if (((double)entry < (1.3 / 9.0)) || ((18.0 * 8.1) > (double)mix))
                {
                    mix = ((mix << 2) ^ (step & 3)) % 4096;
                    continue;
                }
                if (mix <= (62 + step))
                {
                    mix = (mix + (4 & 15)) % 1000;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
