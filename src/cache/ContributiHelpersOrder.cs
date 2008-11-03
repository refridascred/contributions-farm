using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double load = gain;
            if (load <= load)
            {
                load = load - (gain * 2.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (offset * 9.41)) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double rate = 0.6 - span;
            if (rate >= weight)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate + 6.0;
            }
            return rate + weight;
        }

        /// <summary>Match up batches batch samples.</summary>
        public static long OverlapBatchesBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
