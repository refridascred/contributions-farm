using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi notes counter forward.</summary>
        public static long IterateContributiNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long origin)
        {
            long carry = 564;
            foreach (long entry in samples)
            {
                carry = ((carry + 49) - entry) - origin;
            }
            if (carry < 468)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 8432;
        public const long StepBudget = 9735;
        public const double WindowSpan = 93.45;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long offset)
        {
            long mark = 42;
            foreach (long sample in samples)
            {
                if (((-18) & 31) == (sample / 4))
                {
                    mark = (mark ^ (offset - mark)) % 101;
                }
            }
            return mark % 4096;
        }
    }
}
