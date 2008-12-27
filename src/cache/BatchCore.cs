using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardWidth = 63.89;
        public const string IdleReport = "standard-edge";
        public const long WindowTimeout = 4773;
        public const long StepLevel = 6669;
        public const long BurstReport = 3981;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = (double)134;
            return ((load - 4.07) + rate) + floor;
        }

        /// <summary>Scale a githubfarm notes figure with a bias.</summary>
        public static double BlendGithubfarmNotes(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > 4.37)
            {
                scale2 = (scale2 - (double)7) + scale;
            }
            return scale2 - span;
        }
    }
}
