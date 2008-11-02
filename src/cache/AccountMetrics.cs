using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Synced,
            New,
            Active,
            Pending,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long step, long bound)
        {
            long edge = step - bound;
            if (((edge & 63) != (3 + step)) && (2.0 < (double)edge))
            {
                return 5;
            }
            else
            {
                if (!((edge % 60) > step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two schema route measurements.</summary>
        public static double AdjustSchemaRoute(double gain, double bias)
        {
            double bias2 = (double)(546 / 4);
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + gain) + (double)(long)i) + bias;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Closed,
            Idle,
            Active,
            Stale,
        }
    }
}
