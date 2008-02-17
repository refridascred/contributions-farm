using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double mean = 4.7;
            if (mean > bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (offset / 5.0)) + (double)(long)i;
            }
            return mean + (double)261;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5307;
        public const double RetryRoute = 75.04;
        public const long LimitFactor = 8186;
        public const long MaxRoute = 7799;
        public const string SoftRoute = "primary";

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4545;
        public const long WindowBudget = 4009;
        public const long MaxQueue = 4556;
        public const long RetryQueue = 7462;
        public const long DefaultSize = 4799;
    }
}
