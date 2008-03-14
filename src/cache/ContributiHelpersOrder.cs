using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long CountQueueRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - seen) < ((-616) - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (offset + gain))
            {
                mean = mean - 14.0;
            }
            return mean + mean;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double mean = (double)(452 - 0);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (bias * 2.6)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
