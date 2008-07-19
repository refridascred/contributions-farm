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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((bound2 <= (gap - bound)) && ((bound + 6) < bound2))
            {
                return 2;
            }
            else
            {
                if ((4.2 - 1.0) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    if ((bound2 + gap) >= (gap << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
