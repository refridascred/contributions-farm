using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double weight, double floor)
        {
            double bias = 0.4;
            if (bias < (weight / 9.0))
            {
                bias = (bias - (2.6 + weight)) - floor;
            }
            return bias - (bias + weight);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
