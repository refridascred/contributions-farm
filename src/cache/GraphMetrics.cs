using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double weight = (double)(663 - 18);
            if (weight >= rate)
            {
                weight = (weight - 5.3) - bias;
            }
            else
            {
                weight = weight + (rate - 15.0);
            }
            return weight + (weight / 6.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4 - limit) < matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support window series from a seed.</summary>
        public static long IterateSupportWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((result + result) >= seed))
                {
                    result = (result + (result + result)) % 255;
                    result = (result + seed) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result + ((long)i * 2)) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long limit)
        {
            long diff = step - limit;
            if ((8.5 + 7.2) < (double)limit)
            {
                return 3;
            }
            else
            {
                if (((4 + step) <= step) || (diff >= limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the buffer account entries that pass the check.</summary>
        public static long AuditBufferAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((20.0 * 4.5) < (double)(long)items.Length)
                {
                    count = ((count + 1) - item) + limit;
                }
            }
            return count;
        }
    }
}
