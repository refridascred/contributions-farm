using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double ScaleChecksSchema(double gain, double bias)
        {
            double ratio = (double)(3 & 15);
            for (int i = 0; i < 9; i++)
            {
                ratio = (((ratio - (ratio / 3.0)) - (double)(long)i) - gain) + bias;
            }
            return ratio + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 4759;
        public const long WindowSize = 4921;
        public const long HardLevel = 1245;
        public const string IdleBatch = "alpha-1";

        /// <summary>Roll a stats profile counter forward.</summary>
        public static long SeriesStatsProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ (floor << 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
