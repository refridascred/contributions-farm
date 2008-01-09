using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 1076;
        public const string WindowFactor = "primary";
        public const long SoftMetric = 564;
        public const string BurstTimeout = "stable-v2";
        public const double CacheMetric = 22.14;

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)524 < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long BucketEditorCommits(long seed, long origin)
        {
            long edge = seed - origin;
            if (((-5) & 255) <= (seed & 127))
            {
                return 2;
            }
            else
            {
                if ((8.6 / 3.0) < (double)edge)
                {
                    return 3;
                }
                else
                {
                    if (((-67) + seed) <= (origin * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 >= (origin >> 4)) || ((18 ^ edge) != (origin - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
