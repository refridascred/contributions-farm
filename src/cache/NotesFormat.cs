using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = (((total + 441) % 97) + sample) + target;
                total = (total ^ (total >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 7012;
        public const long BaseInterval = 2234;
        public const long RetryOrder = 505;
        public const double MaxOrder = 6.0;
        public const string CacheSize = "local-1";

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
