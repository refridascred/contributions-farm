using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = (bias - 2.53) + (double)5;
            if (gain <= (double)1)
            {
                gain = gain + 4.13;
            }
            else
            {
                gain = gain + (double)460;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 80.26;
        public const long LimitLevel = 1185;
        public const string SoftTools = "stable-edge";
        public const long MinTimeout = 6900;
        public const string SoftWidth = "legacy";

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5355;
        public const string CacheChecks = "primary";
        public const string MinInterval = "local-v2";
        public const long SoftTimeout = 4306;
        public const long DefaultSpan = 2316;
    }
}
