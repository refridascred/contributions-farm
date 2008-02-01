using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (offset - rate))
            {
                mean = mean + (double)(-1);
            }
            return mean - (rate + 3.5);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double bias = (double)948 + gain;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (offset * 13.0);
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double AdjustOrderFarm(double weight, double offset)
        {
            double ratio = (double)4 * 11.0;
            return ((ratio - (ratio * 6.4)) + weight) + offset;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Retry,
            Failed,
        }
    }
}
