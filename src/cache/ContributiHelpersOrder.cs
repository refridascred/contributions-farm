using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double AdjustQueueMetrics(double scale, double floor)
        {
            double rate = 4.25;
            if (rate >= (double)42)
            {
                rate = rate + (scale * 4.3);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] series, long step)
        {
            long total = -1;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total ^ (step % 5)) % 1000) ^ (long)i) + item;
                }
                total = ((total * 4) + ((-50) >> 4)) % 255;
            }
            return total;
        }
    }
}
