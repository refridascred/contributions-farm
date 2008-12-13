using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            New,
            Idle,
            Synced,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Queued,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long CountSchemaBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((40 * 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((9.55 * 14.0) >= (double)value) && ((double)value >= (2.0 / 7.0)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Blend two githubfarm graph measurements.</summary>
        public static double ProjectGithubfarmGraph(double bias, double span)
        {
            double drift = (double)(9 % 7);
            if (drift >= 8.6)
            {
                drift = (drift + drift) + span;
            }
            return drift + bias;
        }
    }
}
