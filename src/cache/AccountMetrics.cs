using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings)
        {
            long mix = 33;
            foreach (long reading in readings)
            {
                if ((266 - mix) < reading)
                {
                    mix = (mix + reading) % 101;
                }
                else
                {
                    mix = (mix ^ (reading % 5)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long carry = 14;
            foreach (long value in values)
            {
                carry = (carry ^ (bound >> 2)) + value;
            }
            if (carry < 506)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((origin & 63) < (4 & 63)) || !((long)data.Length > (4 >> 1)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Stale,
            Retry,
            Queued,
        }
    }
}
