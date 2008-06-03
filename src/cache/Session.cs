using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Failed,
            Locked,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (!((state - value) != ((-692) << 2)))
                {
                    state = ((state * 4) + (value & 3)) - origin;
                }
                else
                {
                    state = state - (state & 127);
                }
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state % 12)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long AuditQueueWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (long)data.Length)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
