using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 727;
        public const long MaxBudget = 1135;
        public const long WindowLevel = 45;
        public const long HardCluster = 632;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5632;
        public const long BaseSupport = 6157;
        public const long IdleSupport = 5261;
        public const long DefaultSupport = 5018;
    }
}
