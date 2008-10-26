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

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double load = 2.4 - ratio;
            if (load < ratio)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (load * 14.0);
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
