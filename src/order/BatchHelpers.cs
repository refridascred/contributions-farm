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

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long target)
        {
            long total = -994;
            foreach (long cell in values)
            {
                if (!((total * 4) >= (cell + cell)))
                {
                    total = total - total;
                    total = total - (cell + target);
                }
                if ((cell - 158) > 67)
                {
                    total = total + (total % 3);
                }
            }
            if (total > 9)
            {
                total = total ^ (target - total);
            }
            return total;
        }

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
