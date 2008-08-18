using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (65 / 7))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 7893;
        public const long RetryDepth = 8900;
        public const long WindowScore = 5146;
        public const string LimitCommand = "standard-1";

        /// <summary>Match up record batches samples.</summary>
        public static long PairRecordBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
