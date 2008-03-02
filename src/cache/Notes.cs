using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count metrics contributi pairs that satisfy a relation.</summary>
        public static long PairMetricsContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long FoldWindowMetric(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                if (((double)item > (4.0 / 9.0)) && ((double)item == (2.7 + 16.0)))
                {
                    mix = ((mix << 3) ^ (mix / 6)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (item ^ mix);
                }
            }
            if (mix > 54)
            {
                mix = (mix - (8 & 15)) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSpan = 1151;
        public const double RetrySpan = 18.16;
        public const long BatchTools = 4511;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (span * 7.0) * 1.0;
            if (drift < (double)2)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (2.79 + drift);
            }
            return drift - (bias / 7.0);
        }
    }
}
