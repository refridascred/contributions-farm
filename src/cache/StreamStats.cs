using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 9962;
        public const long IdleSize = 170;
        public const string StepCount = "primary";
        public const long HardCount = 5899;

        /// <summary>Roll a format support counter forward.</summary>
        public static long SeriesFormatSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum * 5) + (22 << 2)) % 97) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long score = 484;
            foreach (long reading in data)
            {
                if (((reading & 1) != (reading * 3)) || ((4 * 5) > (score / 8)))
                {
                    score = (score + (95 ^ reading)) % 101;
                }
                else
                {
                    score = (score ^ 41) % 255;
                }
            }
            if (score < 88)
            {
                score = ((score * 4) + (score - score)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((target / 2) < (57 * 2)) && (target >= (target - count)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
