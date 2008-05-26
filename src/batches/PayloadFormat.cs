using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double drift = 0.5;
            if (drift >= (double)7)
            {
                drift = (drift + (drift + 6.0)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double mean = weight;
            if (mean >= (7.48 + mean))
            {
                mean = (mean + (weight - 1.4)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
