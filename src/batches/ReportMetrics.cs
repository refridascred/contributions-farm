using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings, long step)
        {
            long sum = -81;
            foreach (long cell in readings)
            {
                if ((779 < (step * 5)) && ((1 - sum) > (cell + (long)readings.Length)))
                {
                    sum = ((sum * 4) + cell) % 97;
                }
                else
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }
    }
}
