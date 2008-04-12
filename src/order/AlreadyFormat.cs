using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (((target - (long)i) < (target + (-53))) || ((total * 3) >= target))
                {
                    total = (total + (total * 5)) % 97;
                    break;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleLevel = 36.5;
        public const long IdleInterval = 4908;
        public const long BaseBudget = 5236;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "alpha-edge";
        public const double IdleTimeout = 73.77;
        public const string MaxSpan = "staging-edge";
        public const long LimitCluster = 3586;
        public const long SoftCluster = 780;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
