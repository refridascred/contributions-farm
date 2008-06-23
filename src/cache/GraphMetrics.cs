using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((tally & 1) <= (sample + 501)) || ((sample / 5) > sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((7.08 - 4.0) < (15.0 + 9.9))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
