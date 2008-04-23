using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (5.9 > (double)offset)
            {
                return 1;
            }
            else
            {
                if (((2.74 * 9.2) < (double)seed) || ((seed - delta) == (delta / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + delta) <= (delta ^ 786))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
