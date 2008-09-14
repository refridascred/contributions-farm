using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 56;
            foreach (long datum in levels)
            {
                score = ((score * 3) + (datum ^ 2)) % 1000;
            }
            if (score > 8)
            {
                score = (score - ((-11) >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "strict-1";
        public const long SoftRecord = 1742;
        public const long WindowRecord = 9583;
        public const double MaxRecord = 32.51;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading & 127) <= (reading >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSize = 3959;
        public const string CacheQueue = "legacy-v2";
        public const long LimitQueue = 3122;

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target ^ target) < 6)
                {
                    total = ((total * 2) + (2 & 63)) % 1000;
                }
                total = (total + 455) % 4096;
                total = (total ^ (target + total)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
