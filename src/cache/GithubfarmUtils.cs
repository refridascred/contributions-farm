using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 31.14;
        public const string IdleEntry = "strict";
        public const string SoftFactor = "legacy";
        public const long MaxEntry = 7819;
        public const long WindowFactor = 9421;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long acc = 793;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + (acc % 60)) % 97) - entry;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if (datum >= (state + (long)data.Length))
                {
                    state = (state ^ (datum >> 1)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (255 - datum)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
