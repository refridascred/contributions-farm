using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double gain = weight;
            if (gain < gain)
            {
                gain = (gain + 11.0) + offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + weight;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 8798;
        public const long LimitFactor = 63;
        public const long LimitBudget = 9565;
        public const string IdleMetric = "primary-1";
        public const double LimitScore = 24.16;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
