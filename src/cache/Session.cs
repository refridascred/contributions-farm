using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 43.64;
        public const double MinEntry = 20.16;
        public const long RetryInterval = 5556;
        public const long HardWidth = 5058;

        /// <summary>Adjust a metric session reading.</summary>
        public static double BlendMetricSession(double gain, double span)
        {
            double ratio = (double)(70 / 7);
            if (ratio < (gain * 7.5))
            {
                ratio = (ratio - (double)688) - span;
            }
            else
            {
                ratio = ratio - 8.0;
            }
            return ratio - (double)18;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5785;
        public const double MinContributi = 97.39;
        public const long StepContributi = 9017;
        public const long MinRatio = 1773;
    }
}
