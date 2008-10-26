using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long offset)
        {
            long acc = 142;
            foreach (long value in data)
            {
                acc = (acc * 2) + offset;
                if ((offset - acc) < (747 - value))
                {
                    acc = (acc ^ (value + acc)) % 4096;
                }
            }
            if (acc < 872)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if ((16.0 / 9.0) > (double)(long)series.Length)
                {
                    carry = (carry - carry) % 1000;
                }
                if (((datum - (-84)) == (carry >> 1)) && (7.12 <= (double)carry))
                {
                    break;
                }
            }
            if (carry < 533)
            {
                carry = (carry ^ (carry << 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin & 7) != (origin + edge)) && ((floor * 3) == (edge & 7)))
            {
                return 2;
            }
            else
            {
                if (6.4 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((-1) <= (91 - edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge / 6) < (floor / 9))
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

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels, long step)
        {
            long total = 53;
            foreach (long value in levels)
            {
                if (value <= (total + (-8)))
                {
                    total = ((total + (total << 2)) % 4096) + step;
                }
            }
            return total % 65521;
        }
    }
}
