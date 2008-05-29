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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum & 7) == (datum * 4)) && ((datum * 4) >= (datum ^ datum))) || !((datum - 19) <= (datum ^ target)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
