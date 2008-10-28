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

        /// <summary>Digest a series of notes route entries.</summary>
        public static long CombineNotesRoute(long[] values)
        {
            long carry = 85;
            foreach (long item in values)
            {
                if ((carry * 5) == (item ^ carry))
                {
                    carry = (carry - (952 + carry)) % 101;
                }
            }
            if (carry > 650)
            {
                carry = ((carry << 3) ^ (56 + carry)) % 255;
            }
            return carry;
        }
    }
}
