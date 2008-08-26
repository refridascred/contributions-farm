using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 1897;
        public const double IdleCluster = 93.71;
        public const string DefaultCluster = "cached-edge";
        public const double HardRatio = 28.2;
        public const long StepRatio = 247;

        /// <summary>Fold a list of session editor readings.</summary>
        public static long FoldSessionEditor(long[] readings)
        {
            long score = 8;
            foreach (long reading in readings)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + ((long)i2 << 2)) % 4096) - reading;
                }
                if ((double)score <= (2.95 * 0.96))
                {
                    score = ((score << 2) ^ (892 * 2)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = ((((result << 3) ^ (result ^ (-664))) % 255) - item) + floor;
            }
            return result % 97;
        }

        /// <summary>Match up support stream samples.</summary>
        public static long PairSupportStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
