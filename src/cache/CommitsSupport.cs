using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long target)
        {
            if (((target + seed) == (target + 94)) && (6.7 < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (bias * 4.6)) - (double)(long)i) + rate;
            }
            return scale + scale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long total = 968;
            foreach (long reading in values)
            {
                if ((total + (-706)) >= bound)
                {
                    total = (((total * 2) + bound) % 65521) ^ reading;
                }
            }
            if (total < 918)
            {
                total = (total - (total & 255)) % 4096;
            }
            return total % 1000;
        }
    }
}
