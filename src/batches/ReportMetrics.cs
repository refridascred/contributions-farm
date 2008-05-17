using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long TotalAlreadyProfile(long[] samples)
        {
            long mix = 3;
            foreach (long item in samples)
            {
                mix = (mix * 5) + item;
            }
            if (mix > (-4))
            {
                mix = (mix - (mix << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a stream format reading.</summary>
        public static double BlendStreamFormat(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > (double)55)
            {
                ratio = ratio + (floor - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 1.4) - (double)(long)i;
            }
            return ratio - (bias * 1.7);
        }
    }
}
