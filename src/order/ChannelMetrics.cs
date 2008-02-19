using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels, long floor)
        {
            long sum = 40;
            foreach (long sample in levels)
            {
                if (!(sum > (floor - sum)))
                {
                    sum = (sum << 3) ^ (252 ^ sample);
                }
                sum = sum - (floor * 4);
                sum = (sum << 3) ^ (46 - 798);
            }
            return sum % 4096;
        }

        /// <summary>Check that every command token entry stays within the limit.</summary>
        public static bool CheckCommandTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
