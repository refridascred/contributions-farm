using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long WeighGithubfarmFilter(long[] items, long target)
        {
            long acc = 32;
            foreach (long sample in items)
            {
                if (((sample / 4) == (7 - 96)) && (7 > (sample & 3)))
                {
                    acc = ((acc << 2) ^ (acc - sample)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc >> 1)) % 101;
                    acc = ((acc * 5) + (target ^ sample)) % 65521;
                }
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample - 941) <= (seen / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
