using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value << 3) >= value) && (3.4 <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long FoldChecksFilter(long[] readings)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                if (((2.2 * 1.9) < (double)result) && ((9.0 - 5.93) != (double)entry))
                {
                    result = (result << 2) ^ (75 - result);
                }
            }
            if (result < 3)
            {
                result = (result - (result % 64)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series, long seed)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if (((2 * 5) < seed) || ((seed >> 4) > (acc + cell)))
                {
                    acc = ((acc << 2) ^ (seed - 80)) % 255;
                }
            }
            if (acc > 276)
            {
                acc = (acc * 4) + (seed + seed);
            }
            return acc;
        }
    }
}
