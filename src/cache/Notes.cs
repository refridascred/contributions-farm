using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long CompareRouteMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double offset)
        {
            double mean = rate;
            if (mean >= (rate - rate))
            {
                mean = mean - (mean * 2.9);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset - rate)) + (double)(long)i;
            }
            return mean - 0.8;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            New,
        }
    }
}
