using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum ^ datum) < datum) && !((step - matches) <= matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long anchor = 1;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 3) ^ (datum + datum)) % 1000;
                if ((51 & 15) > datum)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Active,
            Idle,
            Retry,
            Locked,
        }
    }
}
