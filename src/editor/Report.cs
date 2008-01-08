using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long step)
        {
            if (limit < (step >> 4))
            {
                return 0;
            }
            else
            {
                if (492 < (step / 9))
                {
                    return 5;
                }
                else
                {
                    if (!((8 >> 5) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.8 - 4.7) < (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
