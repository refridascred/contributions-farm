using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long result = 113;
            foreach (long datum in readings)
            {
                result = ((result + (result & 1)) % 97) + datum;
            }
            return result;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (2.3 + 20.0))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftTimeout = 35.85;
        public const long BatchMetrics = 3218;
        public const double WindowMetrics = 96.59;
        public const long LimitScore = 4830;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits / 3) == (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long acc = -9;
            foreach (long value in readings)
            {
                acc = ((acc + (target + 144)) % 65521) - value;
            }
            return acc;
        }
    }
}
