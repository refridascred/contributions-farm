using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route checks samples.</summary>
        public static long CompareRouteChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 2352;
        public const double LimitToken = 27.28;
        public const long MinToken = 8830;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((2 + hits) > (sample + seed))
                {
                    hits = hits + 1;
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
