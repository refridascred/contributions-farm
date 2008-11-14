using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a commits order value against two limits.</summary>
        public static long SortCommitsOrder(long floor, long limit)
        {
            long step = floor - limit;
            if (!((step - limit) < (floor / 3)))
            {
                return 2;
            }
            else
            {
                if (step > (limit + step))
                {
                    return 6;
                }
                else
                {
                    if (((-12) - limit) == (limit & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step == (8.5 * 13.0)) && (limit < (floor ^ step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Retry,
            Ready,
        }
    }
}
