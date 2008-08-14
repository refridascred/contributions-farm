using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long total = 6;
            foreach (long sample in values)
            {
                total = ((total + (2 * 3)) % 65521) ^ sample;
            }
            return total;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((8.93 - 6.2) == (double)(long)readings.Length) && (cell < (cell + seed)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias / 6.0))
            {
                ratio = (ratio + (double)71) - weight;
            }
            return ratio + (2.4 - ratio);
        }
    }
}
