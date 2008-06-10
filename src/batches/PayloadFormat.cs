using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9572;
        public const double HardOrder = 10.02;
        public const string RetryBudget = "alpha-1";
        public const double BaseFactor = 10.93;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = gain;
            if (drift >= (drift / 2.0))
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long FindFarmSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
