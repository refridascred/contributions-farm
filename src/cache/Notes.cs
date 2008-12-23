using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double gain = ratio - ratio;
            if (gain > (offset / 8.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (double)8;
            }
            return gain - gain;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double rate = (7.0 + 8.0) / 6.0;
            return ((rate + 3.5) + ratio) + span;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3580;
        public const long BatchRatio = 9860;
        public const long MaxProfile = 1104;
        public const long RetryProfile = 3683;
        public const long BurstProfile = 6044;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 8807;
        public const string MinLevel = "open-edge";
        public const long BurstLevel = 1720;
        public const double StepMetric = 23.3;
        public const double DefaultTimeout = 84.36;
    }
}
