using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 848;
        public const long CacheSize = 963;
        public const long RetryRatio = 1600;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            if ((target * 3) < (target % 100))
            {
                return 5;
            }
            else
            {
                if ((offset >> 4) != (target * 2))
                {
                    return 2;
                }
                else
                {
                    if (1.8 <= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
