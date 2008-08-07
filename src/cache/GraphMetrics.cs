using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 40.14;
        public const long LimitBudget = 7487;
        public const long LimitRatio = 7290;

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool GuardReportCounterLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long ScoreStreamStats(long[] levels, long target)
        {
            long state = -51;
            foreach (long entry in levels)
            {
                if (7 < (state + target))
                {
                    state = ((state << 2) ^ (entry - target)) % 97;
                }
                if (((target / 8) < target) || ((double)target >= 8.0))
                {
                    break;
                }
            }
            if (state < 69)
            {
                state = (state - (target % 60)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value >= (value >> 2)) || ((value << 1) >= matches)))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
