using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)39) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long GradeCommandBatches(long step, long seed)
        {
            long slot = step ^ seed;
            if (((slot + seed) <= seed) || ((8.0 + 1.2) != (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed & 15))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed < 20.0) || ((seed - slot) < (seed << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 3) >= (seed - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
