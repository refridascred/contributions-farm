using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftDepth = "stable-1";
        public const string IdleSupport = "legacy-v2";
        public const long LimitSupport = 2019;
        public const double BurstSupport = 95.02;
        public const string RetryTimeout = "strict-edge";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double load = floor - gain;
            if (load < gain)
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
