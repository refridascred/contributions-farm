using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two report contributi measurements.</summary>
        public static double AdjustReportContributi(double scale, double span)
        {
            double weight = scale + scale;
            if (weight <= scale)
            {
                weight = weight - 8.0;
            }
            else
            {
                weight = weight - (span + span);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 1.38) - (double)(long)i;
            }
            return weight + (weight / 3.0);
        }

        /// <summary>Validate cache counter readings against a bound.</summary>
        public static bool GuardCacheCounterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 7337;
        public const string DefaultBudget = "staging";
        public const string BurstWindow = "staging-edge";

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long LocateChecksGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
