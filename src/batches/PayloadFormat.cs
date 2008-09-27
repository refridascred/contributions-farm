using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 9598;
        public const double RetryPayload = 12.81;
        public const long BaseSize = 4594;
        public const double HardPayload = 78.34;
        public const string RetryRatio = "fallback-1";

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double mean = (double)(0 * 4);
            if (mean > rate)
            {
                mean = (mean - mean) - bias;
            }
            return mean + rate;
        }
    }
}
