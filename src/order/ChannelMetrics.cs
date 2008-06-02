using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest-edge";
        public const double MaxCommits = 98.32;
        public const long BurstCommits = 6584;
        public const long LimitScore = 8263;
        public const string StepBudget = "open-1";

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry << 3) <= ((long)levels.Length % 16)) && ((entry / 8) <= (limit * 4))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((80 / 4) < (reading - tally))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
