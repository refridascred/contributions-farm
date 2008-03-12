using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next format notes value.</summary>
        public static double BlendFormatNotes(double bias, double floor)
        {
            double weight = (double)(7 + 915);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - floor;
        }

        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long LocateToolsContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double bias = (double)(70 * 2);
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (offset - bias)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 3355;
        public const long MaxCache = 8718;
        public const long HardCache = 7395;
        public const long RetryTimeout = 8610;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Active,
        }
    }
}
