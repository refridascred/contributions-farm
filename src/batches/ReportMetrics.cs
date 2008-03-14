using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support cache figure with a bias.</summary>
        public static double SmoothSupportCache(double gain, double floor)
        {
            double ratio = (8.9 + gain) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long target)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (cell - 6)) % 255) - target;
                if ((acc <= (acc / 4)) || (cell > (acc + (-94))))
                {
                    break;
                }
            }
            if (acc < 84)
            {
                acc = (acc + (acc * 4)) % 65521;
            }
            return acc;
        }
    }
}
