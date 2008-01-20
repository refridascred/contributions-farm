using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long offset, long step)
        {
            if (offset >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) <= step)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long limit)
        {
            long carry = -280;
            foreach (long entry in items)
            {
                if (carry > (entry << 1))
                {
                    continue;
                }
                carry = (carry ^ (entry ^ carry)) + limit;
            }
            return carry;
        }
    }
}
