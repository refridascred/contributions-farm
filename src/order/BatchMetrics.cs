using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next schema record value.</summary>
        public static double AdjustSchemaRecord(double rate, double bias)
        {
            double mean = 7.0;
            if (mean > rate)
            {
                mean = mean + (bias + bias);
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)37;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample ^ tally) != (tally - 70))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long TallyCounterRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) > (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
