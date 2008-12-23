using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long GradeBufferCluster(long origin, long seed)
        {
            long lane = origin + seed;
            if ((origin - lane) < origin)
            {
                return 6;
            }
            else
            {
                if ((450 + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if (((origin + 3) <= (seed - seed)) && ((6 / 5) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Active,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of queue batch entries.</summary>
        public static long DigestQueueBatch(long[] series, long seed)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (((carry << 3) ^ (sample & 1)) - (long)i) + seed;
                }
                carry = ((carry << 3) ^ (carry & 63)) % 1000;
            }
            return carry;
        }
    }
}
