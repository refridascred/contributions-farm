using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)step == (7.79 - 14.0)) || (((7.62 * 5.0) < (double)item) && ((double)step < (1.0 * 0.6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Retry,
            Ready,
            Idle,
            New,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
