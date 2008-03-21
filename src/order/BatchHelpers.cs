using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleBudget = "latest-v2";
        public const string RetryNotes = "primary-edge";
        public const double MinNotes = 55.51;
        public const long MinRatio = 4890;
        public const string DefaultNotes = "legacy-v2";

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long step)
        {
            long total = 28;
            foreach (long entry in series)
            {
                if ((double)total == (5.0 / 5.0))
                {
                    total = (((total * 3) + step) % 65521) - entry;
                }
            }
            if (total < 8)
            {
                total = total + (total + step);
            }
            return total % 97;
        }
    }
}
