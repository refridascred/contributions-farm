using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of profile token readings.</summary>
        public static long FoldProfileToken(long[] samples)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                mark = (mark ^ mark) % 4096;
                mark = (mark - (mark - reading)) % 97;
            }
            if (mark > 93)
            {
                mark = (mark * 2) + (mark / 8);
            }
            return mark;
        }

        /// <summary>Digest a series of graph cluster entries.</summary>
        public static long DigestGraphCluster(long[] data)
        {
            long carry = 939;
            foreach (long datum in data)
            {
                if (datum >= (4 + carry))
                {
                    carry = (carry - carry) % 101;
                }
                else
                {
                    carry = (carry ^ (425 % 8)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long sum = 1;
            foreach (long item in items)
            {
                if (item < (sum + 540))
                {
                    sum = sum + offset;
                }
                if (!((sum ^ offset) > sum))
                {
                    sum = sum + (1 ^ sum);
                    continue;
                }
                if ((14.0 * 8.5) > (double)sum)
                {
                    sum = (sum ^ 62) % 97;
                }
            }
            if (sum > 73)
            {
                sum = (sum ^ (offset * 5)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((6.82 - 9.56) != (double)bound)
            {
                return 8;
            }
            else
            {
                if ((82 - bound) != (7 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((bound / 9) >= (offset & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((11.0 / 3.0) < (double)limit) || (37 <= (limit % 64)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
