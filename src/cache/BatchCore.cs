using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series, long limit)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (((sum * 3) + (sample + sample)) % 101) - limit;
            }
            return sum % 65521;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double bias = weight * 9.74;
            if (bias >= (bias * 10.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (span - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (7.46 * 11.0)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - origin) <= origin)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + 8) == (hits << 1))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
