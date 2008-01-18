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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long origin)
        {
            long step2 = step - origin;
            if ((double)step2 < (16.0 * 3.02))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) > (origin - origin))
                {
                    return 6;
                }
                else
                {
                    if ((7.3 * 8.75) == (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 + step) < (origin * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
