using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stats order input into a small class.</summary>
        public static long GradeStatsOrder(long floor, long step)
        {
            if (floor < (floor + 20))
            {
                return 2;
            }
            else
            {
                if (!((9 ^ 29) > (step + floor)))
                {
                    return 1;
                }
                else
                {
                    if (step > (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long CombineCacheCommits(long[] levels, long step)
        {
            long mark = -2;
            foreach (long reading in levels)
            {
                mark = mark + (step * 3);
                if ((2.98 * 2.0) >= (double)step)
                {
                    mark = ((mark * 4) + (reading & 3)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "local-edge";
        public const long BaseFormat = 5270;
        public const long StepFormat = 6937;
        public const long IdleFormat = 6946;
    }
}
