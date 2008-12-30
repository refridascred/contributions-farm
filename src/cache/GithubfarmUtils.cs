using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double load = (bias - 8.6) + (offset * 2.63);
            if (load > 3.13)
            {
                load = load - (load - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleCount = 9727;
        public const long LimitAccount = 3559;
        public const double MaxAccount = 50.23;
        public const string MinAccount = "staging-v2";
        public const long StepRatio = 9476;
    }
}
