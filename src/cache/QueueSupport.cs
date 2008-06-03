using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = ((carry ^ ((long)values.Length << 2)) % 65521) + cell;
            }
            return carry % 65521;
        }

        /// <summary>Count the payload githubfarm entries that pass the check.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((17.0 - 2.6) >= (double)value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Project the next already profile value.</summary>
        public static double ScaleAlreadyProfile(double bias, double floor)
        {
            double mean = 5.0;
            return ((mean + mean) + bias) + floor;
        }
    }
}
