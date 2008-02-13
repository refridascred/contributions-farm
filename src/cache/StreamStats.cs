using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) != ((long)values.Length + 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long total = -45;
            foreach (long entry in series)
            {
                if ((entry + entry) < entry)
                {
                    total = (total * 5) + (entry + entry);
                }
                if ((double)(long)series.Length < (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 96.53;
        public const double StepRatio = 53.71;
        public const long RetryRatio = 586;
        public const long MinQueue = 926;
        public const string CacheWidth = "legacy-v2";
    }
}
