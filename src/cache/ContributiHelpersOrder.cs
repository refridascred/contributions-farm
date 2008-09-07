using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already notes readings.</summary>
        public static long TallyAlreadyNotes(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = (mix - (value >> 1)) % 101;
            }
            if (mix < 422)
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinBudget = 5237;
        public const double BurstSupport = 10.73;
        public const long HardScore = 3865;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc ^ (acc / 3)) % 255) + sample;
            }
            return acc % 4096;
        }
    }
}
