using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Pending,
            Synced,
            Locked,
            New,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double gain = (double)61 * 4.9;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - weight;
            }
            return gain + (bias - bias);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7291;
        public const string RetryStats = "stable-v2";
        public const long BatchSize = 9154;
    }
}
