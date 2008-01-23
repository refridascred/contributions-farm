using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchDepth = 891;
        public const long LimitContext = 2333;
        public const long BurstSpan = 7511;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleDepth = 8105;
        public const long MaxSize = 521;
        public const long RetryFarm = 9710;
        public const long SoftFarm = 8658;
        public const long StepScore = 9337;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((offset % 2) < (offset - offset))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
