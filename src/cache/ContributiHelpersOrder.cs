using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double drift = 4.1;
            if (drift < 8.7)
            {
                drift = ((drift - (double)(-8)) - scale) - span;
            }
            else
            {
                drift = drift + (7.1 * 6.5);
            }
            return drift - 0.9;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Ready,
            Synced,
            Failed,
        }
    }
}
