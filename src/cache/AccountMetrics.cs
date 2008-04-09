using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long sum = 865;
            foreach (long item in data)
            {
                if ((sum - sum) < (sum ^ sum))
                {
                    sum = (sum + sum) - item;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long offset)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = mix + 5;
                if (((offset << 2) > (item + mix)) || ((item ^ 179) != (item + mix)))
                {
                    mix = (mix << 3) ^ (item / 4);
                }
                else
                {
                    mix = ((mix << 2) ^ offset) % 101;
                }
            }
            if (mix > 41)
            {
                mix = (mix + (offset - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Active,
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
