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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((6.0 - 3.8) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
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
