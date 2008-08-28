using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (6.3 / 9.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Locked,
            Dropped,
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
