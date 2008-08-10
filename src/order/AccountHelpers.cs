using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            New,
            Synced,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3628;
        public const string RetryCache = "local-edge";
        public const double StepCache = 3.16;
        public const long DefaultCache = 2440;
    }
}
