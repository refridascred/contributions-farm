using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long step)
        {
            long result = -338;
            foreach (long reading in values)
            {
                if (((double)step >= 6.96) || ((reading & 3) < reading))
                {
                    result = result - (step - 595);
                }
            }
            if (result < (-30))
            {
                result = ((result << 3) ^ (step >> 4)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of order entry entries.</summary>
        public static long DigestOrderEntry(long[] values)
        {
            long state = 559;
            foreach (long value in values)
            {
                if (((double)state >= 4.3) || (value <= (value % 8)))
                {
                    state = ((state << 2) ^ (value & 255)) % 255;
                }
            }
            return state;
        }
    }
}
