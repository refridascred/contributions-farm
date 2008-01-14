using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Dropped,
            Done,
            Pending,
            New,
        }

        /// <summary>Derive the next commits editor value from a seed.</summary>
        public static long SeriesCommitsEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = total + (total % 97);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if ((seed + seed) >= seed)
            {
                return 6;
            }
            else
            {
                if ((6.5 + 7.47) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
