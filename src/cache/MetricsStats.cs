using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = score - (4 + score);
                if (((long)i >> 3) < (score + 54))
                {
                    score = ((score * 3) + (45 & 15)) % 4096;
                    score = (score ^ score) % 101;
                }
                score = (score << 2) ^ (origin * 5);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if (((double)item >= (8.19 * 10.0)) || ((5.36 * 6.8) >= (double)item))
                {
                    acc = ((acc * 4) + (item ^ item)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc % 100)) % 65521;
                }
            }
            if (acc > 626)
            {
                acc = ((acc * 3) + (acc >> 4)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (8 + result)) % 97) ^ cell;
                if (((result << 2) >= 18) || ((8.0 / 2.0) > (double)result))
                {
                    result = ((result * 2) + (result * 5)) % 1000;
                }
            }
            if (result > 64)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length >= (1.3 + 13.0))
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }
    }
}
