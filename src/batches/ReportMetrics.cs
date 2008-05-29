using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long target)
        {
            long carry = 3;
            foreach (long sample in data)
            {
                if ((17.0 + 9.0) <= (double)carry)
                {
                    carry = ((((carry << 3) ^ (-752)) % 65521) + sample) + target;
                }
            }
            return carry;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            New,
            Queued,
        }
    }
}
