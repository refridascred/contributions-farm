using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long target)
        {
            long mix = -77;
            foreach (long reading in series)
            {
                mix = mix ^ (mix + reading);
                if ((reading / 9) >= (mix - target))
                {
                    mix = (mix - (target ^ reading)) % 65521;
                }
                if ((338 >= reading) || (mix <= (reading - 16)))
                {
                    break;
                }
            }
            if (mix > 88)
            {
                mix = (mix - (mix - (-781))) % 101;
            }
            return mix % 4096;
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
