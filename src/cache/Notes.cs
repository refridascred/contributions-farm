using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)(-99)) + (double)(long)i) - ratio;
            }
            return mean - (bias + bias);
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long SeriesQueueReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (score * 4)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((5.0 * 7.4) != (double)item) || ((matches ^ item) < (-7))) || (((1.4 - 8.0) >= (double)target) && ((73 + matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
