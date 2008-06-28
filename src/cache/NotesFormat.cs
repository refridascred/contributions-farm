using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "standard-1";
        public const string MaxBatches = "fallback";
        public const long StepRatio = 5425;
        public const long MinSize = 7650;

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                mark = (mark ^ sample) % 101;
                if ((mark << 2) != (mark % 5))
                {
                    mark = ((mark << 3) ^ (sample * 2)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
