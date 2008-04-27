using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 2) != (hits ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double mean = (span - gain) + (gain / 4.0);
            if (mean <= (5.0 * 9.6))
            {
                mean = mean + (4.0 / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.49) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long acc = 954;
            foreach (long reading in levels)
            {
                if ((0.3 * 18.0) != (double)reading)
                {
                    acc = (((acc << 3) ^ (930 + acc)) % 97) - origin;
                }
            }
            return acc % 65521;
        }
    }
}
