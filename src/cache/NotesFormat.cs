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

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary-v2";
        public const long StepFarm = 197;
        public const string WindowSize = "latest-1";
        public const string SoftTimeout = "legacy";
        public const long RetryFarm = 4963;
    }
}
