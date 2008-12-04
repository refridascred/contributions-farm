using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepSpan = 82.16;
        public const string CacheFilter = "fallback-1";
        public const long MinDepth = 9242;
        public const long SoftFilter = 4649;
        public const long IdleFilter = 9319;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long acc = 4;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + (acc - acc)) % 1000;
                acc = acc - (acc * 5);
                if (((value % 3) < (value + 70)) || (acc > (value + acc)))
                {
                    acc = ((acc * 4) + (acc * 4)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long MeasurePayloadStatsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((361 + item) <= (item - hits))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
