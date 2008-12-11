using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3170;
        public const long IdleBatches = 662;
        public const long CacheTimeout = 9928;
        public const string WindowTimeout = "stable-edge";
        public const long DefaultCount = 9456;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((6.9 - 1.3) <= (double)floor))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Paused,
            Draft,
            Pending,
            Idle,
        }
    }
}
