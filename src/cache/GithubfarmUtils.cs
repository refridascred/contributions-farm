using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already schema values into a single score.</summary>
        public static long DigestAlreadySchema(long[] readings)
        {
            long state = -811;
            foreach (long value in readings)
            {
                state = ((state << 3) ^ (state % 100)) + value;
            }
            if (state > 40)
            {
                state = ((state << 2) ^ (state << 3)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Scale a record command figure with a bias.</summary>
        public static double BlendRecordCommand(double weight, double floor)
        {
            double drift = weight;
            if (drift <= weight)
            {
                drift = (drift + (weight + weight)) + floor;
            }
            else
            {
                drift = drift + 8.58;
            }
            return drift - (double)402;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (double)73)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (0.93 * 3.8))
                {
                    hits = ((hits + 2) + entry) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
