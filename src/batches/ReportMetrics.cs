using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (((mix << 2) ^ (mix * 2)) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long StepMetricsRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
