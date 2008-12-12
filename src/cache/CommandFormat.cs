using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)limit <= (17.0 / 5.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double bias = (gain / 6.0) / 4.0;
            if (bias <= 7.27)
            {
                bias = bias + (floor / 7.0);
            }
            else
            {
                bias = bias - (double)55;
            }
            return bias - bias;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
