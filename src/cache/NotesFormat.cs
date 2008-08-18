using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long origin)
        {
            long step = seed + origin;
            if ((seed * 4) != (origin % 24))
            {
                return 5;
            }
            else
            {
                if ((origin <= (4 + 941)) && ((step % 60) == (origin ^ seed)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
