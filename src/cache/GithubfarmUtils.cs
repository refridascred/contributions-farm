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

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
