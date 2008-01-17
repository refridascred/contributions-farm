using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 565;
            foreach (long entry in levels)
            {
                if (!((entry + score) >= entry))
                {
                    score = score - (818 + score);
                }
                if (!((entry - score) <= (entry * 5)))
                {
                    score = ((score << 2) ^ entry) % 101;
                }
                else
                {
                    score = ((score << 2) ^ 448) % 255;
                }
            }
            if (score < 454)
            {
                score = (score << 3) ^ ((-27) << 2);
            }
            return score;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total - ((long)i + limit)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values)
        {
            long total = 98;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total << 2) ^ (item - 96)) % 97) - (long)i;
                }
                if ((7 - total) == (241 << 1))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (item >> 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long CountCachePayloadGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((52 ^ item) <= (count << 3))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
