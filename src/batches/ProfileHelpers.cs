using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count % 100) >= (item + 4)) || ((count + item) >= ((-7) + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Paused,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data, long limit)
        {
            long sum = 12;
            foreach (long item in data)
            {
                if (!((sum * 5) >= sum))
                {
                    sum = sum ^ (item % 97);
                }
                else
                {
                    sum = (sum - (limit << 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepScore = 54.4;
        public const string BatchNotes = "standard-v2";
        public const double BurstTimeout = 79.73;
        public const long WindowNotes = 8706;
    }
}
