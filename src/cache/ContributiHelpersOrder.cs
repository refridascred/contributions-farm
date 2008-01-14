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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length > (5.0 / 4.0))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
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
