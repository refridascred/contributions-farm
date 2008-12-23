using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long sum = 301;
            foreach (long value in samples)
            {
                if (((sum >> 4) < (sum + value)) && (sum >= (sum / 9)))
                {
                    sum = (sum << 3) ^ (sum % 24);
                }
                sum = (sum << 3) ^ value;
                sum = (sum - (value + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen >= (bound - bound))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ 64) % 101;
                mark = mark + (mark << 2);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
