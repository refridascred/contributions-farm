using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 3401;
        public const long StepAccount = 73;
        public const long MaxAccount = 3286;
        public const long DefaultWidth = 9097;

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long WeighCounterCluster(long[] items)
        {
            long sum = 502;
            foreach (long datum in items)
            {
                if (sum >= (sum * 5))
                {
                    sum = ((sum * 5) + 1) % 101;
                }
                else
                {
                    sum = sum ^ (datum ^ 93);
                }
            }
            if (sum > 89)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 2;
            foreach (long sample in samples)
            {
                if ((sample & 7) > (1 * 2))
                {
                    carry = (carry ^ (sample + sample)) % 4096;
                }
                else
                {
                    carry = (carry - (sample % 12)) % 255;
                }
            }
            if (carry < 20)
            {
                carry = carry ^ (carry & 31);
            }
            return carry;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
