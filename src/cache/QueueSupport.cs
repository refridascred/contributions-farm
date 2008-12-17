using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next batches channel value.</summary>
        public static double AdjustBatchesChannel(double ratio, double floor)
        {
            double bias = 6.4;
            return (bias + floor) + ratio;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (7.7 - mean)) + (double)(long)i) - span;
            }
            return mean + 8.19;
        }
    }
}
