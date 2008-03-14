using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinTimeout = 2117;
        public const long WindowEditor = 2690;
        public const long BatchRatio = 8944;
        public const long HardEditor = 11;

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double drift = (bias2 / 5.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 0.74)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
