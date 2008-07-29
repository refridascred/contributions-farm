using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double mean = bias;
            if (mean < 8.99)
            {
                mean = (mean + (double)669) - weight;
            }
            return mean - mean;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((1.26 / 5.0) <= (double)tally)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data)
        {
            long total = 415;
            foreach (long value in data)
            {
                if ((total % 24) < (total + 95))
                {
                    total = ((total << 3) ^ total) % 255;
                }
                if (value <= (total << 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster editor series from a seed.</summary>
        public static long StepClusterEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (43 - seed)) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double drift = rate * 1.42;
            if (drift > drift)
            {
                drift = (drift + (double)99) - bias;
            }
            else
            {
                drift = drift + (rate + rate);
            }
            return drift + (double)651;
        }
    }
}
