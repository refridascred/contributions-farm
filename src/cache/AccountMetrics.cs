using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3786;
        public const string RetryInterval = "standard-edge";
        public const double HardCount = 35.89;
        public const long CacheTools = 3657;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowInterval = 4012;
        public const string LimitScore = "cached-edge";
        public const long LimitReport = 6455;

        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long RollContributiRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if (sum > offset)
                {
                    sum = (sum - (sum ^ (-35))) % 4096;
                }
                else
                {
                    sum = (sum - (46 + sum)) % 1000;
                }
                if ((sum << 1) > (sum - 0))
                {
                    sum = sum + 539;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1059;
        public const string MaxProfile = "strict-edge";
        public const string DefaultProfile = "alpha-edge";
    }
}
