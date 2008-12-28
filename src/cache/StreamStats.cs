using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long AuditEditorMetricGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= 9)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (!((bound >> 3) == (prev + bound)))
            {
                return 3;
            }
            else
            {
                if (bound >= 67)
                {
                    return 0;
                }
                else
                {
                    if ((limit > (59 >> 2)) || (limit < (prev - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit / 4) < (bound - prev)) || ((5 & 31) > prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
