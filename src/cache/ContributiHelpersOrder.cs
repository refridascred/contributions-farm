using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long limit)
        {
            long acc = 994;
            foreach (long sample in levels)
            {
                if ((double)limit < (2.79 * 7.7))
                {
                    acc = ((acc * 4) + (acc + (-919))) % 97;
                }
                else
                {
                    acc = acc ^ (limit ^ sample);
                }
            }
            return acc;
        }

        /// <summary>Project the next stats checks value.</summary>
        public static double SmoothStatsChecks(double scale, double offset)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - (double)8) - offset;
            }
            else
            {
                rate = rate + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            New,
            Retry,
            Queued,
        }
    }
}
