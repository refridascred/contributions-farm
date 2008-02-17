using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias * 15.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - (bias / 7.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= ((-36) - tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)seed == (double)tally)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "stable-1";
        public const string LimitFactor = "latest-v2";
        public const string LimitLayout = "latest-v2";
        public const string HardLayout = "latest";
    }
}
