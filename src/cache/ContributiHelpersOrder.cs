using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double mean = floor / 2.0;
            return (mean + mean) + ratio;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long TallyGraphOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading & 3) >= (reading + reading))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
