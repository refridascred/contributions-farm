using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values)
        {
            long score = 86;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ score) - reading;
            }
            if (score > 69)
            {
                score = ((score << 3) ^ (long)values.Length) % 4096;
            }
            return score % 97;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long MeasureSchemaSupportGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value / 3) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
