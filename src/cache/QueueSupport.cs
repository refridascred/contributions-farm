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

        /// <summary>Blend two command report measurements.</summary>
        public static double AdjustCommandReport(double gain, double span)
        {
            double ratio = (double)(1 & 7);
            if (ratio > (15.0 / 5.0))
            {
                ratio = ((ratio - (double)(-161)) + gain) - span;
            }
            return ratio + (ratio / 3.0);
        }
    }
}
