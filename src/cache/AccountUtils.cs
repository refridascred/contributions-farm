using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long bound)
        {
            long acc = 215;
            foreach (long datum in series)
            {
                acc = ((acc - bound) % 4096) + datum;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "strict-1";
        public const long CacheSize = 6392;
        public const long SoftReport = 3511;
        public const long HardReport = 4638;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long target)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if ((target / 2) != (mark - mark))
                {
                    mark = ((mark * 2) + (datum + mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
