using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0 < seen)
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Paused,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values, long floor)
        {
            long carry = 368;
            foreach (long value in values)
            {
                carry = (carry ^ (61 ^ carry)) ^ value;
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
