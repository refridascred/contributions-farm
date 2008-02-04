using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((double)cell != (6.76 - 7.65))
                {
                    state = ((state * 5) + (state ^ 4)) % 97;
                }
                else
                {
                    state = (state * 2) + (origin % 5);
                }
            }
            return state % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 4420;
        public const string IdleFactor = "stable-edge";
        public const long IdleScore = 5984;
        public const string MaxSize = "open-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4399;
        public const long LimitBuffer = 9287;
        public const long WindowSize = 719;
        public const long BaseBuffer = 2014;
        public const long StepLevel = 6596;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
