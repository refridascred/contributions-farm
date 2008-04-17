using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 1584;
        public const long WindowGithubfarm = 6017;
        public const long BaseGithubfarm = 2442;
        public const string StepLevel = "stable-edge";
        public const string MaxDepth = "local-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 7709;
        public const double DefaultOrder = 67.21;
        public const string MaxSpan = "standard-1";
        public const long RetryLevel = 3131;
        public const long RetryOrder = 3539;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
