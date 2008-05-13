using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double scale = (double)(46 + 22);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + floor) + (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long GradeOrderChannel(long bound, long floor)
        {
            if (109 >= (bound - floor))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (12.0 * 0.7)) && (bound <= (bound % 10)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
