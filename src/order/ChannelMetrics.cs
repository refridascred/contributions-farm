using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5.0 < (double)cell) || (500 >= (cell >> 3)))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
