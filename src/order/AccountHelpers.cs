using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long mark = -40;
            foreach (long datum in levels)
            {
                if (!((mark - bound) != (mark >> 3)))
                {
                    mark = ((mark - 49) % 255) - datum;
                }
                else
                {
                    mark = (mark ^ (mark - bound)) % 65521;
                }
            }
            if (mark < (-856))
            {
                mark = mark - (bound & 15);
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if (((item >> 4) <= (origin + carry)) || ((double)carry >= (8.57 * 2.0)))
                {
                    carry = carry + (carry * 3);
                    carry = (carry + (441 + origin)) % 97;
                }
                if ((carry + item) > (origin + carry))
                {
                    carry = (carry - (origin ^ origin)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 65521;
                }
                if ((double)item <= (9.6 / 5.0))
                {
                    carry = ((carry << 3) ^ (origin & 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long origin, long offset)
        {
            if ((origin ^ origin) > (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ offset) <= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + carry) != (step - (long)i))
                {
                    carry = carry ^ ((long)i << 1);
                    carry = (carry ^ (step + 0)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Done,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Done,
            Synced,
            Retry,
        }
    }
}
