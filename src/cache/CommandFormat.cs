using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long MeasureMetricsLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample < ((-660) * 5))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every queue profile entry stays within the limit.</summary>
        public static bool CheckQueueProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitBudget = 75.05;
        public const double MinReport = 16.9;
        public const string SoftReport = "fallback";
        public const long LimitRatio = 102;

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long WeighChecksGithubfarm(long[] values, long target)
        {
            long score = 281;
            foreach (long reading in values)
            {
                score = (score + (reading - score)) % 4096;
                score = ((score * 4) + target) % 65521;
            }
            return score % 97;
        }
    }
}
