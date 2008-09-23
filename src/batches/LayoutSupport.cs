using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Draft,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)(long)levels.Length < (0.05 - 9.47))
                {
                    count = ((count + 1) - sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1264;
        public const long CacheWidth = 911;
        public const long LimitEntry = 1648;
        public const long BurstEntry = 5206;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double bias = 11.0 + 3.65;
            if (bias >= gain)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (floor * 4.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
