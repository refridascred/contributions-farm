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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long total = 537;
            foreach (long value in readings)
            {
                if (!((935 - (-98)) <= total))
                {
                    total = ((total << 2) ^ total) % 4096;
                    total = ((total * 2) + total) % 65521;
                }
                if ((value - value) <= total)
                {
                    total = ((total * 4) + (total >> 4)) % 101;
                }
                if (((2.7 / 6.0) == (double)value) || ((3.07 - 2.09) > (double)value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSize = 3959;
        public const string CacheQueue = "legacy-v2";
        public const long LimitQueue = 3122;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            New,
            Pending,
        }
    }
}
