using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift >= rate)
            {
                drift = drift - (7.1 + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift + (floor * 8.1);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (hits ^ 8))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long offset)
        {
            long delta = limit + offset;
            if ((offset - offset) >= (delta / 6))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) != (offset - limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
