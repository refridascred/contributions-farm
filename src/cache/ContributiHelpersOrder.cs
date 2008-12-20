using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((offset / 3) == (span & 7))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (20.0 * 17.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = (result - sample) % 4096;
                if (((double)sample == (double)16) || ((double)offset != (5.38 * 1.0)))
                {
                    result = result ^ (70 << 3);
                }
            }
            if (result < (-2))
            {
                result = (result ^ result) % 101;
            }
            return result;
        }
    }
}
