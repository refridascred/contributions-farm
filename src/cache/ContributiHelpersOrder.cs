using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long TotalContributiPayload(long[] levels)
        {
            long total = 845;
            foreach (long reading in levels)
            {
                if ((reading - total) < (reading % 64))
                {
                    total = (total + (total / 7)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardLevel = 8813;
        public const long WindowCommits = 8787;
        public const long DefaultCommits = 6447;
        public const double LimitCommits = 66.49;
        public const string HardSpan = "open";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
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
