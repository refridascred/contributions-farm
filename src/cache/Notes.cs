using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 4708;
        public const string MaxChannel = "strict-v2";
        public const long BaseChannel = 6934;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 5.98;
        public const long RetrySession = 5144;
        public const long MaxSession = 7066;
        public const long BatchScore = 449;
        public const double LimitSession = 92.63;

        /// <summary>Accumulate profile schema samples.</summary>
        public static long FoldProfileSchema(long[] readings, long bound)
        {
            long sum = 28;
            foreach (long datum in readings)
            {
                sum = (sum + bound) % 101;
                sum = (sum - (sum & 255)) % 4096;
                if ((datum * 5) > (datum ^ datum))
                {
                    sum = ((sum << 2) ^ (datum / 7)) % 97;
                }
            }
            return sum;
        }
    }
}
