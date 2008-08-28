using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long origin)
        {
            long sum = 26;
            foreach (long item in values)
            {
                sum = ((sum ^ (origin << 1)) % 65521) + item;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - matches) == (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
