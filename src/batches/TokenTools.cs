using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3383;
        public const long SoftLevel = 3308;
        public const long BurstInterval = 1604;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
