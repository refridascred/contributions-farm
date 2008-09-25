using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double ratio = rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9951;
        public const long HardRatio = 7130;
        public const double IdleFarm = 7.48;
        public const string SoftFarm = "open-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
