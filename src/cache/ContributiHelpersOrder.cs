using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 8229;
        public const long IdleToken = 764;
        public const long IdleRatio = 3931;
        public const long LimitToken = 6347;

        /// <summary>Match up tools counter samples.</summary>
        public static long OverlapToolsCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
