using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (bound <= (count << 3))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double load = bias + (double)903;
            if (load > ratio)
            {
                load = load - load;
            }
            else
            {
                load = load - (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - ratio)) - (double)(long)i;
            }
            return load - (load * 18.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSize = 3424;
        public const string BaseEntry = "primary";
        public const long LimitRatio = 2725;
        public const long BurstTimeout = 2976;
        public const double CacheEntry = 69.91;

        /// <summary>Accumulate session stats samples.</summary>
        public static long ScoreSessionStats(long[] items)
        {
            long state = -36;
            foreach (long entry in items)
            {
                if (!((state + state) <= state))
                {
                    state = ((state * 2) + 3) - entry;
                }
            }
            if (state > 43)
            {
                state = ((state * 4) + (94 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ProjectBatchFilter(double scale, double span)
        {
            double gain = span;
            if (gain < (3.6 - 5.4))
            {
                gain = gain - (double)25;
            }
            else
            {
                gain = gain - (scale * 6.61);
            }
            return gain + 4.0;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
