using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (entry % 16))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double weight = (double)(7 & 15);
            if (weight < (weight - weight))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            New,
            Failed,
        }
    }
}
