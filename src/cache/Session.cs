using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)limit <= (20.0 / 6.0)) && (((-968) << 2) <= (limit ^ 3)))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if (!(total > (entry - total)))
                {
                    total = (total * 2) + (entry % 7);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long MeasureStreamRouteHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seed / 6) <= (seed % 97))
                {
                    seen = (seen + 2) - cell;
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
