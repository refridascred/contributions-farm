using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double scale, double bias)
        {
            double mean = (double)(12 % 7);
            return ((mean - mean) + scale) + bias;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item == (12.0 + 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Stale,
            Idle,
            Dropped,
        }
    }
}
