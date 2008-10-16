using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples)
        {
            long score = -3;
            foreach (long reading in samples)
            {
                if ((double)199 > (double)reading)
                {
                    score = ((score * 4) + reading) % 97;
                    break;
                }
                score = (score - (reading + 73)) % 1000;
                if (reading <= (score - reading))
                {
                    break;
                }
            }
            if (score > 533)
            {
                score = (score + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long DigestBufferFilter(long[] data)
        {
            long carry = 99;
            foreach (long reading in data)
            {
                carry = carry ^ (carry ^ 73);
                if ((carry + 15) < (reading - carry))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + reading)) % 65521;
                }
            }
            if (carry > 872)
            {
                carry = (carry * 3) + (carry >> 1);
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 6.39;
        public const long BaseChecks = 2483;
        public const string SoftTimeout = "legacy-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Stale,
            New,
        }
    }
}
