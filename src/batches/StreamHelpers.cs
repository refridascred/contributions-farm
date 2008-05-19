using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a entry channel figure with a bias.</summary>
        public static double ProjectEntryChannel(double rate, double span)
        {
            double drift = (rate - span) - (3.9 / 4.0);
            if (drift < (double)689)
            {
                drift = drift + (drift / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 17.0) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (12.0 * 6.51))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum * 5) < (seen + 51)) && ((seen + seen) == (datum % 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long LocateStatsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
