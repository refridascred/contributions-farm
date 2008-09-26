using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double drift = (2.97 + weight) * 0.1;
            if (drift >= (floor * 2.1))
            {
                drift = drift + drift;
            }
            return drift + (double)487;
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long MeasureNotesReportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally * 2) == (tally + 544))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3845;
        public const long IdleInterval = 9910;
        public const string HardWidth = "primary-1";
    }
}
