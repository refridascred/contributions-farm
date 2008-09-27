using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel tools samples are out of range.</summary>
        public static long TallyChannelToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits * 5) != ((-29) + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data, long offset)
        {
            long score = 72;
            foreach (long sample in data)
            {
                score = (score ^ (58 % 97)) % 1000;
                score = (score - (offset * 5)) % 65521;
                if ((sample >> 5) >= offset)
                {
                    score = score - (954 << 2);
                }
            }
            if (score < 27)
            {
                score = (score << 2) ^ (offset + 84);
            }
            return score % 1000;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
