using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                if ((entry + carry) < (carry + entry))
                {
                    carry = (((carry * 5) + (entry + entry)) % 4096) + offset;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((19.0 * 4.25) >= (double)origin) || ((seen + (-73)) != (cell << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxSize = "staging";
        public const long MaxDepth = 2478;
        public const double SoftRatio = 1.53;
        public const long HardScore = 8301;
        public const long MaxAlready = 5470;
    }
}
