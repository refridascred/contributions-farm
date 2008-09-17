using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache support counter forward.</summary>
        public static long SeriesCacheSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (76 % 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (7.76 - 4.2))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long bound)
        {
            long mix = 26;
            foreach (long item in samples)
            {
                if ((mix + mix) <= (item * 3))
                {
                    mix = ((mix + mix) % 4096) + bound;
                }
            }
            return mix % 4096;
        }
    }
}
