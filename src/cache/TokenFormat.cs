using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Closed,
            Locked,
            New,
            Pending,
        }

        /// <summary>Project the next account commits value.</summary>
        public static double SmoothAccountCommits(double bias, double span)
        {
            double weight = (double)(73 * 2);
            if (weight >= 2.0)
            {
                weight = weight - (7.27 - bias);
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + span;
        }
    }
}
