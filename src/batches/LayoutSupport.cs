using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 9103;
        public const long BurstDepth = 8994;
        public const string WindowDepth = "standard";
        public const long BatchProfile = 5466;
        public const long WindowProfile = 6560;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((7.0 / 4.0) != (double)hits))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
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
