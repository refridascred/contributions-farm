using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double drift = (span - bias) + (span * 4.3);
            return drift + drift;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double bias = (double)(959 + (-9));
            return (bias - span) + gain;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= (seen % 7))
                {
                    seen = ((seen + 3) - reading) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
