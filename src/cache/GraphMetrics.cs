using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = (gain - floor) - gain;
            if (load > (floor + load))
            {
                load = load + 17.0;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)831;
        }

        /// <summary>Match up format batch samples.</summary>
        public static long OverlapFormatBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                acc = (((acc * 4) + acc) % 255) - cell;
            }
            if (acc > 91)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Active,
            Retry,
            Queued,
        }
    }
}
