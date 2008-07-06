using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long result = 225;
            foreach (long value in readings)
            {
                result = ((result - (result << 1)) % 1000) ^ value;
            }
            if (result > 7)
            {
                result = (result + (3 - result)) % 1000;
            }
            return result % 1000;
        }
    }
}
