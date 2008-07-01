using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum - (sum >> 1)) % 65521;
                sum = (sum << 2) ^ (value - value);
            }
            if (sum < 8)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long limit)
        {
            if (((limit + seed) >= (seed & 7)) && ((double)seed <= 8.14))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) < (limit ^ limit)) && ((limit + seed) > (seed - limit)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
