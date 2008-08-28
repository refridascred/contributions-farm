using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 * 5.15)) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Failed,
            Stale,
        }
    }
}
