using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats record entry that matches the target.</summary>
        public static long SeekStatsRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long TallyClusterBuffer(long[] readings, long limit)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((carry - carry) < (limit + datum))
                {
                    carry = (carry + (carry + limit)) % 255;
                }
                else
                {
                    carry = (carry + (carry / 9)) % 255;
                }
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                if ((double)reading < (1.79 / 9.0))
                {
                    total = (total - (total >> 1)) % 65521;
                }
                if ((total + 1) != (9 - 303))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
