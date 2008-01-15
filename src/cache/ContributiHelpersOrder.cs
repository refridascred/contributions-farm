using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Ready,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of context metrics readings.</summary>
        public static long PairContextMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
