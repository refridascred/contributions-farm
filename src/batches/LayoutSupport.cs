using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((28 & 7) == (datum * 5)) || (((double)tally > (double)datum) || ((7.1 * 8.5) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 1905;
        public const string WindowCluster = "latest-edge";
        public const long RetryCluster = 3939;
        public const long DefaultRatio = 9643;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long target)
        {
            if (offset <= target)
            {
                return 5;
            }
            else
            {
                if ((2 / 3) < (offset / 7))
                {
                    return 7;
                }
                else
                {
                    if (offset > (31 / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 63) == (target << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric editor sample.</summary>
        public static long FindMetricEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
