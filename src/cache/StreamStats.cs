using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of context record readings.</summary>
        public static long DigestContextRecord(long[] data, long floor)
        {
            long score = 995;
            foreach (long datum in data)
            {
                score = (score * 3) + (datum / 8);
                if ((datum % 16) <= (floor - datum))
                {
                    score = score ^ (datum % 8);
                }
            }
            if (score < 5)
            {
                score = ((score * 5) + (floor * 3)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double drift = (double)(4 ^ 9);
            if (drift <= (7.86 * 4.8))
            {
                drift = drift + bias;
            }
            return drift - scale;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
