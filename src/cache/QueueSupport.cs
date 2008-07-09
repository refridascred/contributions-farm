using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long CountMetricTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((6.3 * 9.0) == (double)sample)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
