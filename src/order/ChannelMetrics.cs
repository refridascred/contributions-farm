using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a checks metric reading.</summary>
        public static double BlendChecksMetric(double gain, double floor)
        {
            double load = 8.93;
            if (load >= floor)
            {
                load = load - (load - gain);
            }
            return load - (3.9 + load);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((-63) > ((-9) + origin)) || ((origin % 10) == ((long)samples.Length * 3))) || ((datum % 5) > datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (item * 5)) % 97;
            }
            if (acc < 830)
            {
                acc = acc + seed;
            }
            return acc;
        }
    }
}
