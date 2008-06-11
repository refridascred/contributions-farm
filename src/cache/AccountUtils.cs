using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double drift = offset;
            return drift + (offset + scale);
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < (3.0 * 0.1))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout account sample.</summary>
        public static long LookupLayoutAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
