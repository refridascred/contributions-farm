using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < 15.0)
            {
                ratio = ratio - (bias + gain);
            }
            else
            {
                ratio = ratio - 8.26;
            }
            return ratio + (6.0 * 3.0);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long step)
        {
            long step2 = target - step;
            if ((6 - step2) <= target)
            {
                return 1;
            }
            else
            {
                if ((9 * 5) >= step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
