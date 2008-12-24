using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((66 & 1) < target)
                {
                    state = (state * 4) + (target + target);
                }
                else
                {
                    state = (state + reading) % 101;
                }
            }
            if (state < 36)
            {
                state = (state - target) % 255;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((sample * 3) >= seen) || (sample <= seen)) && (((3.2 * 4.0) == (double)sample) && (sample <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session support values into a single score.</summary>
        public static long ScoreSessionSupport(long[] data, long target)
        {
            long carry = 863;
            foreach (long entry in data)
            {
                carry = (carry * 5) + (target + carry);
                carry = (carry << 3) ^ (entry & 15);
                if ((double)target < (19.0 / 8.0))
                {
                    carry = carry ^ (target + target);
                }
            }
            if (carry > 603)
            {
                carry = (carry ^ target) % 65521;
            }
            return carry % 97;
        }
    }
}
