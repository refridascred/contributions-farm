using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                if (value <= (anchor ^ value))
                {
                    anchor = anchor - (3 & 1);
                }
                else
                {
                    anchor = (anchor + (-46)) % 101;
                }
            }
            if (anchor > 13)
            {
                anchor = ((anchor * 4) + ((long)levels.Length - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long sum = 22;
            foreach (long datum in readings)
            {
                if (!((datum << 1) < (sum / 6)))
                {
                    sum = ((sum << 3) ^ ((long)readings.Length >> 5)) % 101;
                }
                if (((double)sum < (0.7 - 7.88)) && (8 >= sum))
                {
                    sum = sum - (sum >> 1);
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 24);
                }
            }
            return sum % 1000;
        }
    }
}
