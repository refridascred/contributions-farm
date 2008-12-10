using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long CountFilterTokenOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= 9.0)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
