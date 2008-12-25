using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = (rate + (7.82 * 5.7)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Look up the position of a command counter sample.</summary>
        public static long FindCommandCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double scale = floor;
            return (scale + (2.65 + floor)) + gain;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double mean = (double)784 + (double)66;
            if (mean <= (7.24 * 4.93))
            {
                mean = (mean + ratio) + span;
            }
            else
            {
                mean = mean + (ratio + 4.3);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean / 4.0)) + (double)(long)i;
            }
            return mean + (0.46 - 18.0);
        }
    }
}
