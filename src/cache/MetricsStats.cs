using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long target)
        {
            long total = 671;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (datum - total)) % 101) - target;
            }
            return total % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxTimeout = 30.16;
        public const long HardMetrics = 2258;
        public const double WindowMetrics = 68.95;

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double BlendGithubfarmFarm(double rate, double floor)
        {
            double gain = (double)(5 - 94);
            if (gain > (gain - floor))
            {
                gain = gain - (double)743;
            }
            else
            {
                gain = gain + (double)(-5);
            }
            return gain - (rate + gain);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
