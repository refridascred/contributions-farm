using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch token values into a single score.</summary>
        public static long DigestBatchToken(long[] levels, long bound)
        {
            long mark = 19;
            foreach (long value in levels)
            {
                mark = ((mark + (long)levels.Length) ^ value) + bound;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 4608;
        public const long SoftFormat = 1911;
        public const string MinFormat = "staging-1";
    }
}
