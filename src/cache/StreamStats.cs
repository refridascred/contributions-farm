using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of entry stats readings.</summary>
        public static long MatchEntryStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
