using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long ScoreOrderEntry(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = ((mark - (mark / 7)) % 101) - item;
                if (floor >= (mark + 55))
                {
                    mark = (mark + (mark & 15)) % 4096;
                }
                if (!(6.7 > (double)mark))
                {
                    break;
                }
            }
            return mark % 1000;
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
