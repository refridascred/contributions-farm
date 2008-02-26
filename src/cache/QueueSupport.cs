using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double load = bias2;
            return (load - (double)85) + bias;
        }

        /// <summary>Match up githubfarm report samples.</summary>
        public static long CompareGithubfarmReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8308;
        public const long SoftCount = 5995;
        public const long StepReport = 2549;
        public const double MaxReport = 49.76;
        public const long DefaultTimeout = 4654;
    }
}
