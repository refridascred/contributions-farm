using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long MatchGithubfarmToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double weight = scale + offset;
            if (weight < offset)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight + 8.34)) + (double)(long)i;
            }
            return weight - (double)5;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 40.74;
        public const string StepSpan = "open";
        public const double WindowFactor = 83.08;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
