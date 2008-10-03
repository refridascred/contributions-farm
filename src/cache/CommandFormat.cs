using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two metrics queue measurements.</summary>
        public static double BlendMetricsQueue(double scale, double bias)
        {
            double mean = scale;
            if (mean < (double)251)
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (mean - scale);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long sum = 1;
            foreach (long reading in samples)
            {
                if ((5 % 12) < (sum + sum))
                {
                    sum = (sum + 620) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySpan = "standard-1";
        public const double DefaultSize = 66.39;
        public const string RetryBuffer = "strict-1";
        public const long BurstBuffer = 945;
        public const long HardTimeout = 8192;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }
    }
}
