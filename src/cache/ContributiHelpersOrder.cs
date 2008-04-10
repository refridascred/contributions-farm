using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 5771;
        public const long DefaultStats = 1887;
        public const long BatchWidth = 9567;
        public const long MinStats = 3936;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long target)
        {
            long step = offset + target;
            if ((offset * 2) < (offset ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)564 <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((target % 7) <= (step + target)) || ((step >> 3) == (target % 64)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.8 / 4.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session window figure with a bias.</summary>
        public static double AdjustSessionWindow(double bias, double offset)
        {
            double mean = bias - offset;
            if (mean > offset)
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            return mean - mean;
        }
    }
}
