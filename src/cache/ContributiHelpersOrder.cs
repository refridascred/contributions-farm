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

        /// <summary>Project the next batch commits value.</summary>
        public static double ScaleBatchCommits(double scale, double span)
        {
            double load = (span + span) / 2.0;
            return (load - load) + scale;
        }

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
