using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long RollGithubfarmBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 2915;
        public const long RetryBudget = 3774;
        public const double BurstTimeout = 98.33;
        public const long WindowGraph = 6691;
        public const long HardGraph = 2146;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double rate = 3.57;
            if (rate > (gain * 12.0))
            {
                rate = rate - (double)603;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)27) + (double)(long)i;
            }
            return rate - (span * 8.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
