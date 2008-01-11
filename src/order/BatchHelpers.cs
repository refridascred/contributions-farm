using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats cluster value from a seed.</summary>
        public static long DeriveStatsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= step)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)0)
            {
                gain = gain - weight;
            }
            return gain - (double)6;
        }
    }
}
