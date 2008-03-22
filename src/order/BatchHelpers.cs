using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long SeekRouteChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)226)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio - 0.21;
        }
    }
}
