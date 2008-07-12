using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long sum = 55;
            foreach (long datum in values)
            {
                if ((datum + datum) < (sum - datum))
                {
                    sum = sum ^ (datum + 10);
                }
                if (!(datum <= (datum + 0)))
                {
                    sum = ((sum * 3) + 347) % 97;
                }
                else
                {
                    sum = (sum - (origin % 12)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches >= (1.7 + 0.16))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long WeighGraphSchema(long[] series, long step)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                if ((14.0 * 9.29) != (double)datum)
                {
                    anchor = ((anchor << 3) ^ (step ^ datum)) % 65521;
                    anchor = (anchor * 5) + 4;
                }
                if ((datum + anchor) >= 134)
                {
                    anchor = ((anchor * 3) + (anchor - step)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Locked,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if (entry <= (461 >> 3))
                {
                    state = (state + entry) % 97;
                }
            }
            return state;
        }
    }
}
