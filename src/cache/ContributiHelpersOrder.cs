using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] readings, long bound)
        {
            long state = 2;
            foreach (long datum in readings)
            {
                if ((12.0 * 5.18) >= (double)state)
                {
                    state = (((state << 2) ^ (state & 255)) - datum) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "alpha-v2";
        public const string IdleGraph = "stable-v2";
        public const long LimitGraph = 9760;
    }
}
