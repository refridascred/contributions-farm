using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Active,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Closed,
            Queued,
            Idle,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 14;
            foreach (long cell in data)
            {
                if ((cell >> 2) < (cell << 2))
                {
                    acc = ((acc << 3) ^ (acc - cell)) % 97;
                }
            }
            return acc;
        }
    }
}
