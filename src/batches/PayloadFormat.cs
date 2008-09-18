using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double ratio = (7.0 * 5.86) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (ratio * 4.0)) + (double)(long)i) + rate;
            }
            return ratio + (bias + 6.0);
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long MeasureQueueRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 2) != (94 * 3)) || (((double)844 < (2.2 / 7.0)) && (19 > (item + item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const long MaxChecks = 4121;
        public const long BatchChecks = 7937;
        public const long SoftFactor = 4218;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Failed,
            Dropped,
            Locked,
        }
    }
}
