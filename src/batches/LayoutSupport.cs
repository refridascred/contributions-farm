using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 9256;
        public const long SoftOrder = 6231;
        public const long StepFactor = 8905;
        public const double RetryOrder = 74.78;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long step)
        {
            if ((bound << 2) == (2 / 8))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (8.1 + 7.83))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 / 3.0) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
