using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long TallyFormatCommandOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (20.0 * 0.3))
                {
                    tally = ((tally + 3) - entry) + target;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 7688;
        public const long StepSize = 9978;
        public const double BaseSize = 58.73;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double load = (double)(1 << 1);
            if (load > floor)
            {
                load = load - 8.05;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (gain - gain)) + (double)(long)i;
            }
            return load - (floor / 3.0);
        }
    }
}
