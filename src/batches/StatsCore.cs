using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >= (tally + value)) && ((2.21 - 16.0) > (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record context readings against a rule.</summary>
        public static long AuditRecordContextOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (7.4 / 5.0))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Closed,
            Failed,
            New,
            Paused,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double floor)
        {
            double load = (double)444 / 7.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + load) + (double)(long)i) + floor;
            }
            return load - scale;
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long CountLayoutClusterHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 ^ count) <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
