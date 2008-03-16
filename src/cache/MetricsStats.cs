using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSize = 773;
        public const long WindowQueue = 7220;
        public const long BaseQueue = 867;
        public const long CacheQueue = 3877;
        public const long BurstQueue = 9929;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 13;
            foreach (long datum in series)
            {
                if (((datum ^ limit) <= (limit + datum)) || (((long)series.Length & 3) >= (datum / 6)))
                {
                    break;
                }
                if ((9.47 / 3.0) == (double)state)
                {
                    state = ((state * 5) + (34 - datum)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Count filter checks pairs that satisfy a relation.</summary>
        public static long CompareFilterChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mark = 94;
            foreach (long value in series)
            {
                mark = (((mark << 2) ^ (mark * 5)) % 255) - value;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "strict-edge";
        public const long BatchDepth = 8498;
        public const double MaxPayload = 79.05;
    }
}
