using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 2048;
        public const long StepChecks = 7386;
        public const long HardSize = 9071;
        public const long MinSpan = 2978;
        public const long MaxRatio = 5746;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor - 5) ^ datum;
            }
            if (anchor > 5)
            {
                anchor = anchor - (limit >> 3);
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = ((carry << 3) ^ (7 * 2)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Active,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data)
        {
            long acc = 76;
            foreach (long cell in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc - (acc << 1)) ^ (long)i;
                }
                acc = (acc * 5) + (acc - acc);
                if ((2.89 - 0.94) <= (double)acc)
                {
                    acc = acc - (cell + cell);
                }
            }
            return acc;
        }
    }
}
