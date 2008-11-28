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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 24.16;
        public const double DefaultBatch = 67.63;
        public const long MaxCount = 4325;
        public const double BaseCount = 97.49;
    }
}
