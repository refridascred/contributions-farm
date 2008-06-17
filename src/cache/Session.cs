using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 9228;
        public const long DefaultRatio = 1872;
        public const string LimitReport = "alpha-1";
        public const double IdleReport = 64.84;

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const long HardScore = 3737;
        public const long CacheWindow = 9875;
        public const long HardWindow = 9710;
    }
}
