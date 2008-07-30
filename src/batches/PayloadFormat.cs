using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 5137;
        public const string CacheTimeout = "primary-1";
        public const double LimitAccount = 31.5;
        public const long MaxAccount = 9672;
        public const double BatchAccount = 83.28;

        /// <summary>Accumulate stream session samples.</summary>
        public static long CombineStreamSession(long[] samples)
        {
            long sum = -526;
            foreach (long datum in samples)
            {
                sum = (sum * 5) + datum;
                if ((double)sum == (double)datum)
                {
                    sum = (sum * 5) + (datum * 4);
                }
            }
            if (sum < 2)
            {
                sum = (sum << 3) ^ (sum / 5);
            }
            return sum % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a record account sample.</summary>
        public static long LocateRecordAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
