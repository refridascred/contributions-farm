using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double drift = (double)(69 - 932);
            return (drift - (bias + 7.44)) + span;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
