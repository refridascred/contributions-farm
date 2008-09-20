using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long target)
        {
            long step = origin - target;
            if ((step << 2) < target)
            {
                return 2;
            }
            else
            {
                if ((5.0 + 16.0) >= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double rate = 15.0;
            return (rate - (5.1 - weight)) + span;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
