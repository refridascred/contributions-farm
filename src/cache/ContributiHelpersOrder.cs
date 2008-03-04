using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                if ((cell / 4) <= (65 * 4))
                {
                    mark = mark - (cell ^ 24);
                }
                if ((6.0 * 8.26) > (double)offset)
                {
                    mark = ((mark << 3) ^ (3 % 2)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (offset - cell);
                }
            }
            if (mark > 744)
            {
                mark = (mark + (offset + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 9436;
        public const long HardLevel = 3200;
        public const long MinLevel = 215;
        public const string WindowSize = "open-edge";
    }
}
