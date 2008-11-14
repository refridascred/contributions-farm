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

        /// <summary>Accumulate context token samples.</summary>
        public static long CombineContextToken(long[] data)
        {
            long mark = 258;
            foreach (long reading in data)
            {
                mark = mark + (mark + reading);
            }
            return mark % 65521;
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
