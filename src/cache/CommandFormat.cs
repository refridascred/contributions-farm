using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseDepth = 603;
        public const long StepBatch = 5634;
        public const string StepFactor = "alpha-edge";
        public const long SoftBatch = 658;

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long ScoreQueueMetrics(long[] series, long limit)
        {
            long mark = 368;
            foreach (long sample in series)
            {
                if ((double)limit == (double)sample)
                {
                    long next = (sample - (-33)) >> 3;
                    mark = (mark ^ (512 + next)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + (sample >> 1)) % 4096;
                }
                if ((mark << 3) > (sample / 4))
                {
                    mark = ((mark << 3) ^ (5 % 24)) % 4096;
                }
                mark = ((mark << 3) ^ (mark + limit)) % 65521;
            }
            if (mark < 5)
            {
                mark = (mark * 2) + (limit * 2);
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 4) + anchor) % 1000;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
