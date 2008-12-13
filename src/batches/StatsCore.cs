using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            New,
            Idle,
            Synced,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Closed,
            Dropped,
            Idle,
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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((step - item) > (step ^ 910)) || ((double)matches > (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
