using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of cluster support readings.</summary>
        public static long MatchClusterSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Blend two account cluster measurements.</summary>
        public static double ScaleAccountCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = (gain - 4.0) - floor;
            }
            return gain + gain;
        }

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
