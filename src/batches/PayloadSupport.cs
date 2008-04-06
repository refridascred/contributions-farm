using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(cell >= limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - 822) > (seed + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i > carry))
                {
                    carry = (carry ^ (origin / 4)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
