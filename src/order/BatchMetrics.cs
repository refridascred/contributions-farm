using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long seed)
        {
            if ((step + seed) <= 0)
            {
                return 5;
            }
            else
            {
                if (((9.92 - 2.9) >= (double)step) && (step >= (step - step)))
                {
                    return 2;
                }
                else
                {
                    if (((140 ^ seed) != (step - seed)) && ((double)seed > 17.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate report batch samples.</summary>
        public static long DigestReportBatch(long[] samples, long floor)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                state = ((((state << 3) ^ state) % 1000) ^ entry) + floor;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Draft,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches > 9.53)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
