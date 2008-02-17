using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long mark = 59;
            foreach (long item in data)
            {
                if ((double)item == (18.0 - 18.0))
                {
                    mark = (mark - (item * 2)) % 4096;
                }
            }
            if (mark < 51)
            {
                mark = (mark ^ (mark % 64)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (result + (81 / 6)) % 1000;
                result = ((result * 3) + sample) % 4096;
            }
            return result;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((7.29 + 11.0) != (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
