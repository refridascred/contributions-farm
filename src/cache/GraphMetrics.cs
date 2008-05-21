using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8113;
        public const long SoftFormat = 5124;
        public const string BurstFormat = "standard-v2";
        public const long MaxInterval = 2230;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long CountChecksCounterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length != (item + item))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7874;
        public const double MaxWindow = 49.2;
        public const double BaseLevel = 93.59;
        public const long IdleBudget = 6201;

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                acc = acc + (reading / 3);
                acc = ((acc << 2) ^ (reading / 3)) % 1000;
                if (((double)floor == (13.0 + 8.0)) && ((638 * 3) >= (floor % 60)))
                {
                    break;
                }
            }
            if (acc > (-606))
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }
    }
}
