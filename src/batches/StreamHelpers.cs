using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double gain = (double)6 * 4.13;
            if (gain < ratio)
            {
                gain = (gain - (double)5) - bias;
            }
            else
            {
                gain = gain + (double)(-92);
            }
            return gain - gain;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 54.73;
        public const long BurstSpan = 8522;
        public const double HardSpan = 79.72;
        public const long MinFactor = 199;
        public const string BurstBudget = "latest-1";

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool VerifyStreamChecksBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 883;
        public const double IdleGithubfarm = 55.07;
        public const long RetryCount = 9620;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long limit)
        {
            long sum = -748;
            foreach (long reading in values)
            {
                sum = ((sum - (sum * 3)) - reading) - limit;
            }
            return sum;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
