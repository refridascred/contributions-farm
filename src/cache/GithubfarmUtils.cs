using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "latest-edge";
        public const long LimitFormat = 3741;
        public const string CacheFormat = "legacy-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = (double)1 / 9.0;
            if (load >= 4.1)
            {
                load = ((load - (double)0) - ratio) + bias;
            }
            return load + (8.35 - 0.97);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i ^ bound)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
