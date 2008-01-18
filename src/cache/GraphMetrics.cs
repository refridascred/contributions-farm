using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = (double)(2 * 4);
            if (mean <= (mean + rate))
            {
                mean = mean - (9.0 + rate);
            }
            else
            {
                mean = mean - (rate - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)594) + (double)(long)i;
            }
            return mean - (rate * 5.6);
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
