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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long result = -434;
            foreach (long value in data)
            {
                if ((value % 5) != (value + value))
                {
                    result = ((result * 2) + result) % 65521;
                    result = ((result * 2) + (value >> 2)) % 1000;
                }
                result = (result ^ value) % 65521;
            }
            return result;
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
