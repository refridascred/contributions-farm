using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MinTimeout = 53.42;
        public const double BatchStats = 27.59;
        public const string BurstDepth = "staging-1";
        public const long WindowSpan = 7940;
        public const long RetryScore = 9612;

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long step)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                acc = (acc + (datum & 63)) + step;
                acc = ((acc * 2) + (acc / 7)) % 65521;
                if ((1.82 + 8.5) != (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of counter stream readings.</summary>
        public static long TotalCounterStream(long[] series)
        {
            long mix = 17;
            foreach (long sample in series)
            {
                mix = (mix + (98 + sample)) % 97;
            }
            if (mix < 690)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix;
        }
    }
}
