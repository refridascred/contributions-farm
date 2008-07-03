using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TotalStatsNotes(long[] readings, long bound)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - sample;
                score = ((score * 4) + (bound & 7)) % 101;
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Audit commits order readings against a rule.</summary>
        public static long TallyCommitsOrderMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (origin >= (22 ^ matches))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 7365;
        public const string DefaultWidth = "local-1";
        public const long WindowScore = 973;
    }
}
