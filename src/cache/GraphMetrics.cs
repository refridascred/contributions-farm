using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheDepth = 36.52;
        public const long CacheBudget = 7419;
        public const string BatchChecks = "standard-edge";
        public const double BatchRatio = 7.36;

        /// <summary>Adjust a commits stats reading.</summary>
        public static double SmoothCommitsStats(double rate, double offset)
        {
            double drift = (8.0 / 9.0) * 0.18;
            return ((drift + drift) + rate) + offset;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch layout samples.</summary>
        public static long CombineBatchLayout(long[] data)
        {
            long anchor = 38;
            foreach (long reading in data)
            {
                if ((double)775 <= (double)anchor)
                {
                    anchor = (anchor - (anchor - anchor)) ^ reading;
                }
                else
                {
                    anchor = (anchor * 4) + 76;
                }
            }
            return anchor;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }
    }
}
