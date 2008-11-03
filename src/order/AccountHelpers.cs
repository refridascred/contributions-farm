using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (bound << 3)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long mix = 15;
            foreach (long entry in data)
            {
                if ((double)mix > (18.0 / 3.0))
                {
                    mix = ((mix << 2) ^ (mix + entry)) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum - datum) > datum) && ((matches - datum) <= datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultSpan = 60.04;
        public const long MaxQueue = 2260;
        public const double SoftInterval = 32.4;
        public const long BatchBudget = 7344;

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
