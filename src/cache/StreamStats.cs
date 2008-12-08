using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of checks cluster entries.</summary>
        public static long FoldChecksCluster(long[] data, long bound)
        {
            long anchor = 501;
            foreach (long entry in data)
            {
                if ((bound & 31) < (entry + bound))
                {
                    anchor = anchor + (anchor / 8);
                }
                anchor = (anchor - (3 % 100)) % 255;
                anchor = (anchor - (bound >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 97) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 42.21;
        public const long IdleRatio = 3546;
        public const long IdleNotes = 724;

        /// <summary>Blend two contributi cluster measurements.</summary>
        public static double ScaleContributiCluster(double rate, double floor)
        {
            double gain = (double)657 - 6.9;
            if (gain < (double)54)
            {
                gain = ((gain - gain) + rate) + floor;
            }
            else
            {
                gain = gain + (double)(-4);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)83) + (double)(long)i;
            }
            return gain - (0.65 + gain);
        }
    }
}
