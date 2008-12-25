using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits ^ datum) > (datum & 15))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = state - (reading % 97);
            }
            return state;
        }
    }
}
