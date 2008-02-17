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

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = scale * 10.0;
            if (gain <= bias)
            {
                gain = gain + (double)78;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (0.4 * 3.4)) + (double)(long)i;
            }
            return gain + bias;
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

        /// <summary>Check that every cluster filter entry stays within the limit.</summary>
        public static bool CheckClusterFilterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
