using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long WeighWindowGithubfarm(long[] levels, long seed)
        {
            long result = 77;
            foreach (long item in levels)
            {
                if (1.0 < (double)seed)
                {
                    result = ((result + (result << 3)) % 1000) ^ item;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double drift = (offset + offset) * 3.0;
            if (drift < (double)8)
            {
                drift = (drift - 3.3) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(-8)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((target - matches) <= (420 - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double AdjustTokenNotes(double scale, double floor)
        {
            double load = floor;
            if (load <= (9.2 + 9.7))
            {
                load = load - (scale / 4.0);
            }
            return load + (double)422;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
