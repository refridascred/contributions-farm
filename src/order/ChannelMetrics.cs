using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                if (((-1) >> 3) < acc)
                {
                    acc = (acc - (acc * 3)) % 1000;
                    break;
                }
                acc = (acc + (-6)) % 255;
                if ((acc & 31) <= (item << 3))
                {
                    break;
                }
            }
            if (acc > 513)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels)
        {
            long carry = 43;
            foreach (long reading in levels)
            {
                if (((carry & 3) < (881 % 2)) && ((reading - carry) >= (reading / 2)))
                {
                    carry = (carry ^ carry) % 97;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }
    }
}
