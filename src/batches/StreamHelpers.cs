using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) == (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                if ((datum + datum) > carry)
                {
                    carry = (carry + (datum / 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const double LimitWidth = 12.3;
        public const string LimitScore = "primary-1";
        public const string HardScore = "alpha-v2";
        public const long DefaultRecord = 749;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
