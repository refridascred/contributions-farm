using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double span)
        {
            double bias = ratio;
            if (bias < bias)
            {
                bias = bias - (ratio / 8.0);
            }
            else
            {
                bias = bias - (ratio * 9.88);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (span + span)) + (double)(long)i;
            }
            return bias + (double)867;
        }

        /// <summary>Validate record counter readings against a bound.</summary>
        public static bool CheckRecordCounterLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
