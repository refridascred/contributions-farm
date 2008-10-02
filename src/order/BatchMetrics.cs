using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long target)
        {
            if (target > (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((target * 2) >= (target - offset))
                {
                    return 5;
                }
                else
                {
                    if (((-15) * 5) <= (offset + 92))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 239;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long TallyGraphContributiOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 93) >= cell)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 3238;
        public const double CacheRatio = 29.05;
        public const double RetryLayout = 89.26;
        public const long RetryFactor = 3097;
        public const double MaxLayout = 90.49;
    }
}
