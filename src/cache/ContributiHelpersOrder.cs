using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long carry = 687;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ 970) % 255;
                if ((carry / 2) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long total = -80;
            foreach (long sample in series)
            {
                if ((double)total >= (6.0 + 6.1))
                {
                    total = total - (sample ^ sample);
                }
                else
                {
                    total = (total + (sample + floor)) % 97;
                }
            }
            if (total > 18)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((double)offset != (1.41 / 2.0))
                {
                    sum = sum + sum;
                    sum = ((sum << 2) ^ (offset - (long)i)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
