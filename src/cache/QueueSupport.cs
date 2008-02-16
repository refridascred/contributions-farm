using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (origin ^ 7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((limit - 905) > (span >> 5)))
            {
                return 1;
            }
            else
            {
                if ((span * 3) < (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
