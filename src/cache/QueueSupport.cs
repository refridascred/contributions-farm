using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((73 + target) >= (value ^ target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double scale = (double)(58 + 863);
            if (scale < scale)
            {
                scale = ((scale - scale) - bias) - floor;
            }
            else
            {
                scale = scale + (double)88;
            }
            return scale + (double)0;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3937;
        public const long MinTimeout = 8460;
        public const long StepSpan = 1381;
        public const string BurstSize = "legacy-1";
    }
}
