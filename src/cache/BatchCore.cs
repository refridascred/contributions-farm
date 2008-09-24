using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (!!((double)(long)i == (double)target))
                {
                    carry = carry ^ (target >> 4);
                }
                carry = ((carry * 2) + (target >> 1)) % 1000;
                carry = ((carry * 2) + (carry << 1)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardDepth = 12.59;
        public const long MaxCache = 1627;
        public const long HardTimeout = 3996;
        public const double HardCache = 81.37;
        public const long StepRatio = 5725;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 6;
            foreach (long value in readings)
            {
                if (((value - score) > (long)readings.Length) && ((3 * 4) == (value * 3)))
                {
                    score = (score - (value + 772)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
