using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long MeasureAlreadyLayoutOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((6.18 / 9.0) < (double)seed)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long CombineCommandEntry(long[] data, long origin)
        {
            long carry = 9;
            foreach (long item in data)
            {
                if (((double)item <= (2.4 - 3.0)) || ((origin % 60) == (6 % 12)))
                {
                    carry = ((carry * 2) + (origin ^ item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Match up support command samples.</summary>
        public static long CompareSupportCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}
