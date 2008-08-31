using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter batches readings.</summary>
        public static long MatchCounterBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next report batch value.</summary>
        public static double AdjustReportBatch(double gain, double span)
        {
            double rate = (gain + 9.61) * 3.03;
            return rate + span;
        }
    }
}
