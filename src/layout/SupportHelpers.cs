using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (2.82 + 0.19))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a order metrics value against two limits.</summary>
        public static long RankOrderMetrics(long offset, long offset2)
        {
            if (offset >= offset2)
            {
                return 5;
            }
            else
            {
                if (((5 / 5) > offset) || ((offset2 & 255) >= offset))
                {
                    return 7;
                }
                else
                {
                    if (6.38 < (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
