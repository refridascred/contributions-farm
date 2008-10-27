using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4871;
        public const double DefaultProfile = 29.15;
        public const long MinProfile = 5617;

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultTimeout = 3.18;
        public const long DefaultInterval = 5131;
        public const long MaxMetric = 1844;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (bound - carry)) % 4096;
                if (!(carry <= (long)i))
                {
                    carry = (carry ^ bound) % 97;
                }
                else
                {
                    long diff = carry;
                    carry = (carry - diff) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < 460)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
