using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long floor)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((entry + floor) >= acc)
                {
                    acc = (acc << 3) ^ (acc >> 3);
                    acc = acc ^ 590;
                }
                else
                {
                    acc = acc - acc;
                    acc = (acc - floor) % 255;
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (acc + entry)) % 65521) + (long)i;
                }
                acc = (acc * 4) + 7;
            }
            if (acc > 59)
            {
                acc = ((acc << 2) ^ (765 / 9)) % 101;
            }
            return acc;
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
