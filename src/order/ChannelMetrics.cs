using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long sum = 24;
            foreach (long entry in samples)
            {
                sum = (sum << 2) ^ entry;
                if ((offset + offset) < entry)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
