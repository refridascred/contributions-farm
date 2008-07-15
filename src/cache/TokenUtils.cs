using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up stream format samples.</summary>
        public static long OverlapStreamFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch profile readings against a rule.</summary>
        public static long TallyBatchProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value < (value ^ value)) && (((3.9 / 8.0) < (double)hits) && ((value + hits) != (value / 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
