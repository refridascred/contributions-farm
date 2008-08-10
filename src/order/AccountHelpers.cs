using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 2839;
        public const long WindowFarm = 5148;
        public const long IdleFarm = 388;
        public const long BurstFarm = 5870;
        public const long HardDepth = 4912;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Active,
            New,
            Paused,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftFactor = "local-edge";
        public const long SoftInterval = 4974;
        public const long HardTools = 7026;
        public const long SoftSpan = 3038;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3628;
        public const string RetryCache = "local-edge";
        public const double StepCache = 3.16;
        public const long DefaultCache = 2440;
    }
}
