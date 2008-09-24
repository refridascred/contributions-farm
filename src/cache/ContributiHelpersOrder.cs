using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((7.2 / 8.0) > (double)seen))
                {
                    seen = ((seen + 3) ^ datum) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 5312;
        public const double WindowSpan = 64.21;
        public const long IdleStream = 6478;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - bias2;
            }
            return rate - 18.0;
        }
    }
}
