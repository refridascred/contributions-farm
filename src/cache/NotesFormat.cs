using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i & 255) != (state - origin))
                {
                    continue;
                }
                else
                {
                    state = (state + origin) % 4096;
                }
                if (origin >= (state >> 3))
                {
                    state = (state + (origin >> 5)) % 65521;
                }
                state = (state + ((long)i - origin)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
