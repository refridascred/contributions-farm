using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultCount = "open-edge";
        public const long StepCount = 7716;
        public const long IdleBatch = 1263;
        public const long WindowScore = 53;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= (seed + 717))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a tools graph reading.</summary>
        public static double ScaleToolsGraph(double gain, double offset)
        {
            double scale = gain;
            if (scale >= gain)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (offset / 8.0)) + (double)(long)i;
            }
            return scale + (8.9 * 8.2);
        }
    }
}
