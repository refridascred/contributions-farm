using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a session editor reading by value.</summary>
        public static long LocateSessionEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 5539;
        public const string MinTimeout = "local-v2";
        public const double HardCount = 4.61;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((((-6) ^ 8) >= (item - origin)) || ((origin - 1) == (origin / 7))) && (item < (item + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long target, long offset)
        {
            if ((offset >= (offset + target)) && (target <= (target + offset)))
            {
                return 4;
            }
            else
            {
                if (!((target + offset) <= target))
                {
                    return 2;
                }
                else
                {
                    if (offset > (offset + 292))
                    {
                        return 6;
                    }
                    else
                    {
                        if (6 < target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-v2";
        public const double HardSize = 3.8;
        public const long CacheFactor = 2259;
        public const long MinBudget = 5089;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
