using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Stale,
            Active,
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum < (datum ^ datum)) && ((6.3 * 0.64) > (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
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
