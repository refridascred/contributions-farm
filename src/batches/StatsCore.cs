using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Adjust a context window reading.</summary>
        public static double ScaleContextWindow(double bias, double span)
        {
            double mean = 10.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + (mean + mean)) + (double)(long)i) + bias) + span;
            }
            return mean - (double)81;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "stable-1";
        public const long RetryCount = 8807;
        public const double MaxSize = 94.21;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches <= (716 + step)) || (step >= (7 << 3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
