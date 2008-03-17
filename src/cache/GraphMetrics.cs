using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double scale = bias;
            return scale - gain;
        }

        /// <summary>Audit window farm readings against a rule.</summary>
        public static long TallyWindowFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen > (item % 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
