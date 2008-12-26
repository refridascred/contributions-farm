using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long TallyFormatCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item < (hits / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long mark = 65;
            foreach (long reading in levels)
            {
                if ((double)floor <= (6.0 - 1.0))
                {
                    mark = (mark + (reading + 90)) % 4096;
                }
                if ((mark + mark) <= (reading * 4))
                {
                    continue;
                }
                if ((9 * 3) < mark)
                {
                    mark = ((mark << 2) ^ reading) % 1000;
                }
                if ((mark - 89) <= floor)
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark + 728) % 1000;
            }
            return mark;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 2460;
        public const long BatchWidth = 5593;
        public const double BatchMetrics = 56.85;
        public const long RetryMetrics = 7401;
        public const long IdleMetrics = 8628;
    }
}
