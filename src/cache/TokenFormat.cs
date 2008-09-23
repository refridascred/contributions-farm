using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift < (bias / 9.0))
            {
                drift = (drift + (drift + bias)) - offset;
            }
            else
            {
                drift = drift - (bias * 7.02);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 16.0) + (double)(long)i;
            }
            return drift + (bias / 9.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)offset > (6.9 - 1.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
