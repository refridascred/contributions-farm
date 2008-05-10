using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up schema window samples.</summary>
        public static long MatchSchemaWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long offset)
        {
            long acc = -721;
            foreach (long datum in items)
            {
                acc = (acc - (offset % 5)) - datum;
                acc = ((acc * 2) + offset) % 97;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
