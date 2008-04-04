using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((7.0 / 8.0) < (double)bound)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) == (sample + count))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long floor, long offset)
        {
            long span = floor ^ offset;
            if (!((20.0 * 2.78) <= (double)floor))
            {
                return 8;
            }
            else
            {
                if ((3 & 15) <= (floor - offset))
                {
                    return 6;
                }
                else
                {
                    if ((span << 1) > (0 << 3))
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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            New,
            Locked,
        }
    }
}
