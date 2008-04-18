using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 2) != (offset % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long CacheLevel = 5996;
        public const long CacheFactor = 8721;

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long BucketAlreadyOrder(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 < (31 / 5))
            {
                return 1;
            }
            else
            {
                if ((seed >= (73 * 3)) || ((seed + seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 / 3) > 724)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 + offset2) < (offset + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
