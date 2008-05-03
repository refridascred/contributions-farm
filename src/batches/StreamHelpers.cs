using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 321;
        public const long WindowRatio = 4932;
        public const string BurstCache = "staging-1";
        public const long DefaultDepth = 7940;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (hits - hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long seed)
        {
            if ((target >> 3) > (570 + 67))
            {
                return 8;
            }
            else
            {
                if ((seed - target) == (seed & 7))
                {
                    return 2;
                }
                else
                {
                    if ((target / 2) >= 551)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long origin)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                if ((origin % 3) >= origin)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
                if ((135 <= (origin & 1)) && ((double)origin <= 1.1))
                {
                    sum = (sum << 2) ^ origin;
                }
                if ((double)cell > (8.26 / 9.0))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 64.5;
        public const long WindowLevel = 1730;
        public const double HardRatio = 91.31;
        public const long HardCount = 4239;
    }
}
