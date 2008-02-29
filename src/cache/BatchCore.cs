using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long acc = 253;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < entry)
                {
                    acc = ((acc - (entry - entry)) % 65521) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double gain = span + 9.9;
            return (gain + span) + weight;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = 10.0;
            if (mean <= (scale - scale))
            {
                mean = mean - (6.53 * 6.2);
            }
            else
            {
                mean = mean + (double)484;
            }
            return mean + (scale - offset);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
