using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long offset)
        {
            long carry = -1;
            foreach (long sample in series)
            {
                if (!(offset > (50 ^ (-72))))
                {
                    carry = ((carry - (offset & 255)) % 101) + sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry - (carry - offset)) % 65521;
            }
            return carry % 97;
        }
    }
}
