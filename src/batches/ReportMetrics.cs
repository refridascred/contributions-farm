using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next notes githubfarm value from a seed.</summary>
        public static long RollNotesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (mix - step)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double bias = 8.96;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span + bias)) + (double)(long)i) - weight;
            }
            return bias - bias;
        }
    }
}
