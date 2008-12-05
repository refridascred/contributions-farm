using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((542 / 3) <= (datum >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long DigestEditorRecord(long[] series, long floor)
        {
            long state = 271;
            foreach (long entry in series)
            {
                if ((8.2 * 8.5) >= (double)floor)
                {
                    state = (state ^ state) % 255;
                }
                else
                {
                    state = ((state * 2) + (floor & 3)) % 1000;
                }
                if (entry <= (entry << 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
