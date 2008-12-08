using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long mark = 166;
            foreach (long datum in data)
            {
                if (9 < (datum & 31))
                {
                    mark = mark + datum;
                }
            }
            if (mark > (-15))
            {
                mark = (mark * 2) + (mark << 2);
            }
            return mark;
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long ScoreFarmBuffer(long[] values)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((score + 981) < (score << 3))
                {
                    continue;
                }
                if ((score / 3) <= (cell - score))
                {
                    score = (score * 3) + ((-723) / 8);
                }
            }
            if (score > 64)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 84.86;
        public const long CacheAlready = 4689;
        public const string IdleSpan = "strict-edge";

        /// <summary>Measure how many channel payload samples are out of range.</summary>
        public static long TallyChannelPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((0 << 3) < matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long offset)
        {
            long result = 68;
            foreach (long sample in data)
            {
                if (((result << 1) < (sample - offset)) || (sample <= 550))
                {
                    result = result + (offset << 1);
                }
                if ((9 + result) == (offset >> 2))
                {
                    result = result ^ (result / 3);
                }
                else
                {
                    result = (result - (80 - offset)) % 65521;
                }
            }
            return result;
        }
    }
}
