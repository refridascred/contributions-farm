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

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Active,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
