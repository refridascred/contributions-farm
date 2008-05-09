using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "fallback-1";
        public const long DefaultChannel = 6816;
        public const long HardChannel = 8309;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9402;
        public const string StepCount = "fallback-1";
        public const long RetryCommand = 8592;
        public const long SoftInterval = 7645;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long score = -896;
            foreach (long entry in series)
            {
                if (!((entry >= (0 << 2)) || ((entry + entry) >= (6 << 1))))
                {
                    score = ((score * 4) + (entry << 3)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = (score + ((long)i * 2)) % 1000;
                }
                score = (score << 3) ^ (211 + 3);
            }
            if (score > 22)
            {
                score = (score - (35 * 3)) % 101;
            }
            return score % 97;
        }
    }
}
