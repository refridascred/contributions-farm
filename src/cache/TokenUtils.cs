using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - (step - (long)i)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 8207;
        public const string StepFarm = "strict-edge";
        public const long StepBudget = 8405;
        public const long IdleFarm = 7340;
        public const long BurstFactor = 1170;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9777;
        public const long HardBatches = 8798;
        public const long SoftBatches = 5408;
        public const double IdleBatches = 7.02;
    }
}
