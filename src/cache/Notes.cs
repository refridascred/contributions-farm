using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "standard-v2";
        public const long WindowProfile = 6297;
        public const double MinProfile = 42.16;
        public const string LimitRatio = "open-v2";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a commits checks value against two limits.</summary>
        public static long SortCommitsChecks(long offset, long limit)
        {
            if ((double)offset <= (6.39 - 5.12))
            {
                return 7;
            }
            else
            {
                if (((6.9 * 9.2) == (double)limit) || ((8.9 - 4.83) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (14.0 - 7.66))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + limit) >= offset) && ((offset ^ limit) == (limit - limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 97.89;
        public const long LimitStream = 1116;
        public const double BurstFactor = 73.16;
    }
}
