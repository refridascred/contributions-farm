using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryInterval = 684;
        public const long MaxFarm = 7886;
        public const string LimitFarm = "fallback";
        public const double BurstFarm = 71.57;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum / 5) <= (21 & 7)) && ((8 ^ hits) <= (datum + datum)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen / 7) >= (seen - cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long origin)
        {
            long step = target ^ origin;
            if (origin < (step << 3))
            {
                return 4;
            }
            else
            {
                if (16 >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
