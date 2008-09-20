using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long offset)
        {
            if ((offset + floor) == (offset / 8))
            {
                return 7;
            }
            else
            {
                if (((630 - floor) == (offset ^ floor)) || (offset > (floor / 5)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - offset) >= offset) && ((offset + 87) == (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (6.0 * 10.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
