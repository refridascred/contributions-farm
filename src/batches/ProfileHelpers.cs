using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 7867;
        public const string IdleLevel = "stable-v2";
        public const double SoftSpan = 11.57;
        public const string WindowCount = "local-v2";
        public const string RetryCount = "strict-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count * 5) >= sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entry entries.</summary>
        public static long TotalChannelEntry(long[] series)
        {
            long carry = 340;
            foreach (long sample in series)
            {
                if (((7.46 * 5.56) >= (8.0 - 1.0)) && ((double)carry != (9.0 / 7.0)))
                {
                    break;
                }
                carry = (carry - (carry * 4)) - sample;
            }
            return carry;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
