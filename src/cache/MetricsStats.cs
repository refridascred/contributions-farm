using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "local";
        public const double DefaultBatches = 48.8;
        public const long MinBatches = 8290;

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (weight + 0.89))
            {
                gain = (gain - (weight + gain)) + floor;
            }
            else
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + 7.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 101;
                if (((9.0 - 5.0) < (double)acc) || ((bound & 15) > bound))
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
