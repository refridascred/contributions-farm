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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 96;
            foreach (long sample in levels)
            {
                if ((double)sample != (0.09 - 2.7))
                {
                    mark = (mark - 4) % 4096;
                }
                else
                {
                    mark = mark + (567 + mark);
                }
            }
            if (mark > 88)
            {
                mark = mark - mark;
            }
            return mark % 65521;
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
