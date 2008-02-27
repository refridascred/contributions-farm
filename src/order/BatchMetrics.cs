using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next cluster support value.</summary>
        public static double SmoothClusterSupport(double scale, double bias)
        {
            double gain = (scale - 5.0) - bias;
            if (gain > gain)
            {
                gain = gain + (bias / 5.0);
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (9.86 / 2.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account schema readings against a rule.</summary>
        public static long CountAccountSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((7.0 + 3.6) < (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
