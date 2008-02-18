using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total + target) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
