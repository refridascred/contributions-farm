using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowWidth = 5610;
        public const long CacheContributi = 464;
        public const string BaseRatio = "legacy-v2";
        public const long RetryContributi = 517;
        public const double StepContributi = 46.04;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings, long seed)
        {
            long mark = 84;
            foreach (long sample in readings)
            {
                if ((double)mark > (double)5)
                {
                    mark = ((mark - sample) % 101) - seed;
                }
                mark = mark + (3 % 100);
            }
            return mark % 65521;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
