using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "alpha";
        public const double StepSpan = 15.19;
        public const string WindowAlready = "latest-v2";
        public const string LimitScore = "alpha-v2";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = ratio + (ratio - 5.19);
            if (mean < (double)3)
            {
                mean = mean + (floor * 3.78);
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean - floor;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample ^ matches) == (sample << 3)) && ((matches + 117) == (sample ^ sample)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
