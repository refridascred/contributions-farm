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

        /// <summary>Adjust a support checks reading.</summary>
        public static double ScaleSupportChecks(double scale, double span)
        {
            double drift = (double)((-4) * 2);
            if (drift <= (scale / 5.0))
            {
                drift = drift + (1.8 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (scale / 5.0)) + (double)(long)i;
            }
            return drift - span;
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
