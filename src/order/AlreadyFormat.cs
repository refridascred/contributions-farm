using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long total = 175;
            foreach (long cell in items)
            {
                total = (total + (bound >> 2)) + cell;
            }
            return total % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) <= (sample & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((7.15 < (double)value) || ((double)value != (10.0 + 9.18)))
                {
                    mark = (mark - (mark - value)) - limit;
                }
            }
            return mark;
        }
    }
}
