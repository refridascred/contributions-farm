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

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Draft,
            Stale,
        }

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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
