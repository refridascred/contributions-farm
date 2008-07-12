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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Locked,
            Done,
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            long delta = floor + limit;
            if (limit > (delta - delta))
            {
                return 5;
            }
            else
            {
                if ((limit % 10) > (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((floor >= (floor ^ delta)) && (35 >= (limit << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
