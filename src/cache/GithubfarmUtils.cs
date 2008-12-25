using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate schema report samples.</summary>
        public static long TallySchemaReport(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                if ((value - value) <= score)
                {
                    score = (score + (score ^ score)) % 4096;
                }
                else
                {
                    score = (score - (score & 1)) % 1000;
                }
            }
            if (score > (-759))
            {
                score = score ^ (score + 7);
            }
            return score;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
