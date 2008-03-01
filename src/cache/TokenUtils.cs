using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up schema githubfarm samples.</summary>
        public static long PairSchemaGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (double)66)
            {
                mean = mean + (scale / 8.0);
            }
            return mean - (8.0 / 8.0);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
