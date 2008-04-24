using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSpan = 6013;
        public const long StepCount = 260;
        public const string BaseCount = "staging-edge";
        public const long BurstCount = 8089;
        public const double DefaultChannel = 78.95;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((2.14 / 3.0) >= (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double floor)
        {
            double drift = bias - (floor + 4.4);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
