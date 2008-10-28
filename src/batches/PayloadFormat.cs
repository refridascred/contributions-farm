using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long seed)
        {
            long diff = target + seed;
            if ((98 / 2) >= (diff + 4))
            {
                return 1;
            }
            else
            {
                if ((double)diff >= (8.6 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if ((8.4 * 9.0) >= (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (double)8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long WeighPayloadSchema(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((carry & 7) < (datum >> 4))
                {
                    carry = (carry + (datum % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long state = 518;
            foreach (long cell in items)
            {
                state = ((((state << 2) ^ 42) % 4096) - cell) - limit;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseBudget = 642;
        public const long RetryNotes = 7693;
        public const long MaxLevel = 7131;
        public const long HardNotes = 5499;
    }
}
