using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double gain = (4.23 * 11.0) + offset;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double rate = gain;
            return rate + floor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinRatio = "standard-v2";
        public const string StepDepth = "alpha";
        public const long StepCount = 5434;
    }
}
