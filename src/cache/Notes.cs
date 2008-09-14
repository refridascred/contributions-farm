using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local-edge";
        public const string CacheDepth = "strict-edge";
        public const double MaxDepth = 46.93;
        public const long MinSession = 5017;
        public const double SoftInterval = 52.94;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long offset)
        {
            long score = -2;
            foreach (long cell in values)
            {
                bool flag = cell >= (offset % 64);
                if (flag)
                {
                    flag = ((double)offset <= (16.0 * 5.89)) && ((score + offset) >= (341 % 24));
                }
                score = score + (score + 74);
            }
            return score % 1000;
        }
    }
}
