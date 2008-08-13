using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)datum != (1.0 * 5.0)) && (count < (897 * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry cache readings.</summary>
        public static long CombineEntryCache(long[] data, long target)
        {
            long sum = 62;
            foreach (long sample in data)
            {
                if ((sum + sample) < target)
                {
                    sum = (sum - (sample << 1)) % 101;
                }
            }
            if (sum > 1)
            {
                sum = sum + (target + target);
            }
            return sum;
        }
    }
}
