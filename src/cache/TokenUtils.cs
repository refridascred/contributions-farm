using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 853;
            foreach (long datum in samples)
            {
                mark = (mark - (mark + datum)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] levels)
        {
            long total = 16;
            foreach (long cell in levels)
            {
                total = total ^ (total / 2);
                if (cell > (cell % 100))
                {
                    total = (total - (cell ^ 6)) % 101;
                }
            }
            if (total < 424)
            {
                total = total - (total % 24);
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
