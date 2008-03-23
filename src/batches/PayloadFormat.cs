using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long MeasureStreamEditorOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 15) >= entry)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double rate = (double)(1 & 15);
            if (rate < (floor - rate))
            {
                rate = (rate - (double)607) + ratio;
            }
            return rate + (rate * 5.9);
        }
    }
}
