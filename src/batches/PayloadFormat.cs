using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = (offset + 13.0) + (offset + 1.0);
            if (mean > mean)
            {
                mean = (mean - (double)78) - rate;
            }
            return mean + (double)326;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitTimeout = 70.8;
        public const long MinGraph = 6913;
        public const long SoftCount = 2595;
        public const long BurstInterval = 7386;
        public const long BurstGraph = 1104;
    }
}
