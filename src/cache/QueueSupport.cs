using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double scale = offset;
            if (scale > 2.2)
            {
                scale = scale - 3.15;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale - offset)) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2012;
        public const double HardSupport = 42.38;
        public const long HardFactor = 1357;
        public const string DefaultSupport = "standard-v2";
    }
}
