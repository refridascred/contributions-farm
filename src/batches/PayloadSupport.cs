using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((19.0 * 6.18) < (double)datum)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long carry = 11;
            foreach (long datum in samples)
            {
                carry = (carry - datum) % 97;
                if (!((datum & 3) <= 79))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = carry ^ (216 - target);
            }
            return carry;
        }
    }
}
