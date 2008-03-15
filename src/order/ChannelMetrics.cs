using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Measure how many stream batch samples are out of range.</summary>
        public static long TallyStreamBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell + seen) > (cell / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
