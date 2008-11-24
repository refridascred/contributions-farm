using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if ((100 >> 4) == (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 7) != (seed << 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 520;
        public const long DefaultSize = 5486;
        public const long LimitWidth = 1463;
        public const long WindowCounter = 8410;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long mark = -1;
            foreach (long cell in series)
            {
                mark = ((mark ^ (floor / 5)) % 255) - cell;
            }
            if (mark > 8)
            {
                mark = (mark - (floor + floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long seed)
        {
            long carry = 715;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry - carry) % 4096) ^ (long)i;
                }
                if ((carry + seed) != (carry / 8))
                {
                    carry = (carry << 2) ^ (335 - carry);
                }
                else
                {
                    carry = ((carry * 2) + (seed - value)) % 4096;
                }
            }
            if (carry > (-77))
            {
                carry = (carry ^ (seed + 153)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Classify a stream cluster pair into a bucket.</summary>
        public static long BucketStreamCluster(long offset, long step)
        {
            if (offset < (offset % 10))
            {
                return 7;
            }
            else
            {
                if ((step <= (step + offset)) || ((step % 60) != (offset >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((step + 7) < (offset >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
