using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double scale, double span)
        {
            double ratio = span;
            if (ratio > (span / 9.0))
            {
                ratio = (ratio + (5.0 * 5.6)) + scale;
            }
            return ratio - 8.7;
        }
    }
}
