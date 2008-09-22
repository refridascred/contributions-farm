using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + step) != (tally - step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "fallback-1";
        public const long CacheCounter = 7;
        public const long HardRatio = 7872;
        public const double BatchDepth = 57.97;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7034;
        public const long SoftSupport = 1922;
        public const double BurstSupport = 44.27;
        public const double BurstCount = 35.74;
    }
}
