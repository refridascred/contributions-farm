using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item >> 4) >= (252 * 3))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (!((carry >> 3) < reading))
                {
                    carry = (carry ^ carry) % 4096;
                }
                if ((double)reading == (4.0 - 1.38))
                {
                    break;
                }
            }
            if (carry > 589)
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
