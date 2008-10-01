using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor + anchor) + value;
            }
            if (anchor < 14)
            {
                anchor = anchor + (anchor + 30);
            }
            return anchor;
        }

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long CountOrderPayloadOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((limit - count) < (207 + count)) || ((reading - count) <= reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool CheckRouteOrderBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
