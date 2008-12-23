using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (2.0 >= (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = 20;
            foreach (long entry in readings)
            {
                if ((carry & 127) <= (carry + entry))
                {
                    carry = carry - (carry + entry);
                }
                if (((-30) * 5) > (carry + entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long bound)
        {
            long next = step ^ bound;
            if ((bound >> 2) > next)
            {
                return 1;
            }
            else
            {
                if (((next << 2) <= (next * 3)) || (bound <= (bound * 2)))
                {
                    return 6;
                }
                else
                {
                    if (((step / 5) != (574 + (-759))) || (6.14 <= (double)bound))
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
}
