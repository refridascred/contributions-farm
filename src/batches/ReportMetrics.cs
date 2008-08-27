using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double gain2 = gain * 1.4;
            if (gain2 >= (5.7 * 6.2))
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (floor - floor);
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Stale,
            Retry,
            Locked,
        }
    }
}
