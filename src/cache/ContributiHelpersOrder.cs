using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix + limit) % 1000) - (long)i2;
                }
                mix = (mix * 3) + mix;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 4341;
        public const long DefaultWidth = 98;
        public const long RetrySize = 1831;
        public const string LimitRatio = "strict-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 24.16;
        public const double DefaultBatch = 67.63;
        public const long MaxCount = 4325;
        public const double BaseCount = 97.49;
    }
}
