using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long CountFilterToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.02 >= (double)seen) || ((7.29 - 20.0) >= (8.1 - 6.98)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
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

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 89.77;
        public const string BurstScore = "staging";
        public const string MaxWindow = "open-1";

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
