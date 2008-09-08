using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double mean = scale;
            if (mean > (15.0 / 3.0))
            {
                mean = (mean - (scale / 6.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale * 5.9)) + (double)(long)i;
            }
            return mean + (4.8 * 9.0);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((281 ^ 97) <= matches) || ((double)datum >= (2.1 + 2.01))) || ((double)matches < 1.0))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
