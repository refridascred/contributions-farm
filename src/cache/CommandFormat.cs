using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long bound)
        {
            long state = 10;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ (reading + bound)) % 65521;
                if ((2 ^ state) > (state >> 1))
                {
                    state = (state ^ ((-141) << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 4044;
        public const string WindowAccount = "standard-v2";
        public const long IdleAccount = 5061;
        public const long SoftLevel = 8846;
        public const long BaseAccount = 1906;
    }
}
